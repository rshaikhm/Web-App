using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2.Configuration;
using Test2.Models;
using Test2.Models.Domain;
using Test2.Models.DTO;
using Test2.Models.Repository;
using Microsoft.Extensions.Azure;
using Azure.Storage.Queues;
using Azure.Storage.Blobs;
using Azure.Core.Extensions;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;
using Web.Middlewares;
using ExternalFTPInjestion.Common;
using ExternalFTPInjestion.Models;
using ExternalFTPInjestion.Models.Domain;

namespace Test2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
           
            app.UseOptions();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
           
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

                c.RoutePrefix = string.Empty;

            });
           
            app.UseStaticFiles();
            app.UseCookiePolicy();

            AppConfiguration.SetConfig(Configuration);
            app.UseHttpsRedirection();
            app.UseMvc();


        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<pcssqldbconfigpayroll360devContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:MbkDbConstr"]));
            //services.AddSingleton(Configuration.GetSection("StorageConnectionString").Get<StorageConfiguration>());
            services.Configure<StorageConfiguration>(Configuration.GetSection("StorageConnectionString"));
            services.Configure<StorageConfiguration>(Configuration.GetSection("logAnalyticsAccessKey"));
            services.Configure<StorageConfiguration>(Configuration.GetSection("logAnalyticsWorkSpaceID"));

            services.AddScoped<IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO>, InboundSourceSetupDomain>();
            services.AddScoped<IDataRepository<TblDestinationSetup, TblDestinationSetupDTO>, DestinationSetupDomain>();
            services.AddScoped<IDataRepository<TblFileReceived, TblFileReceivedDTO>, FileReceivedDomain>();

            services.AddAzureClients(builder =>
            {
                builder.AddBlobServiceClient(Configuration["ConnectionStrings:AccessKey:blob"], preferMsi: true);
                builder.AddQueueServiceClient(Configuration["ConnectionStrings:AccessKey:queue"], preferMsi: true);
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "MY API",
                    Description = "A simple example ASP.NET Core Web API",
                   
                });
            });
            
        }

    }
    internal static class StartupExtensions
    {
        public static IAzureClientBuilder<BlobServiceClient, BlobClientOptions> AddBlobServiceClient(this AzureClientFactoryBuilder builder, string serviceUriOrConnectionString, bool preferMsi)
        {
            if (preferMsi && Uri.TryCreate(serviceUriOrConnectionString, UriKind.Absolute, out Uri serviceUri))
            {
                return builder.AddBlobServiceClient(serviceUri);
            }
            else
            {
                return builder.AddBlobServiceClient(serviceUriOrConnectionString);
            }
        }
        public static IAzureClientBuilder<QueueServiceClient, QueueClientOptions> AddQueueServiceClient(this AzureClientFactoryBuilder builder, string serviceUriOrConnectionString, bool preferMsi)
        {
            if (preferMsi && Uri.TryCreate(serviceUriOrConnectionString, UriKind.Absolute, out Uri serviceUri))
            {
                return builder.AddQueueServiceClient(serviceUri);
            }
            else
            {
                return builder.AddQueueServiceClient(serviceUriOrConnectionString);
            }
        }
    }
}
