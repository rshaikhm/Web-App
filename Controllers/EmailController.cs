//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
//using System.Threading.Tasks;
using Test2.Models;
using Test2.Models.Domain;
using Test2.Models.DTO;
using Test2.Models.Repository;
using Microsoft.WindowsAzure.Storage;
//using Microsoft.WindowsAzure.Storage.Blob;
//using Test2.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using System.Text;
//using System.Reflection;
//using Microsoft.OpenApi.Models;
//using Microsoft.AspNetCore.Cors;
using ExternalFTPInjestion.Common;
//using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ExternalFTPInjestion.Models;

namespace Test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmailController : ControllerBase
    {
        private readonly IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO> _dataRepository;
        private readonly IDataRepository<TblDestinationSetup, TblDestinationSetupDTO> _destinationRepository;
        private readonly IDataRepository<TblFileReceived, TblFileReceivedDTO> _fileReceivedRepository;

        private readonly IHostingEnvironment envv;
        private IConfiguration configuration;
        
        public EmailController(IDataRepository<TblInboundSourceSetup, TblInboundSourceSetupDTO> dataRepository,
            IDataRepository<TblDestinationSetup, TblDestinationSetupDTO> destinationRepository,
            IHostingEnvironment _env, IConfiguration iConfig, IDataRepository<TblFileReceived, TblFileReceivedDTO> fileReceivedRepository)
        {
            _dataRepository = dataRepository;
            _destinationRepository = destinationRepository;
            envv = _env;
            configuration = iConfig;
            _fileReceivedRepository = fileReceivedRepository;
        }

        // GET: https://localhost:44312/api/email/1/shelara@pcscapital.com
        [HttpGet("{id}/{mailId}")]
        //[Route("/")]
        public IActionResult Get( int id = 1, string mailId = "" ) // Type_Of_Ingestion , From_Mail_Id
        {
            
            
            
            
            var inboundSrcSetup = _dataRepository.Get(id,mailId);
            var fileNamePattern = _dataRepository.GetData();//Omni,Voya,Paylocity

            
            string accessKey = configuration.GetSection("ConnectionStrings").GetSection("myStorageConnectionString").Value;
            string logAnalyticsAccessKey = configuration.GetSection("ConnectionStrings").GetSection("logAnalyticsAccessKey").Value;
            string logAnalyticsWorkspaceID = configuration.GetSection("ConnectionStrings").GetSection("logAnalyticsWorkspaceID").Value; 

            if (inboundSrcSetup == null)
            {
                return NotFound("InboundSrcSetup not found.");
            }
            else
            {
                var destinationSrcSetup = _destinationRepository.Get(Convert.ToInt64(inboundSrcSetup.DestinationSetupId));
               
                if (destinationSrcSetup == null)
                {
                    return NotFound("Destination Source Setup not found.");
                }
                else
                {
                    UploadFile(inboundSrcSetup, destinationSrcSetup, accessKey, logAnalyticsWorkspaceID, logAnalyticsAccessKey);
                }
            }
            return Ok();
        }

        public static string UploadFile(TblInboundSourceSetup inboundSourceSetup, TblDestinationSetup destinationSourcSetup , string accessKey, string logAnalyticsWorkspaceID, string logAnalyticsAccessKey)
        {
            string destinationUrl = destinationSourcSetup.DestinationFolderPath;
            string containerName = string.Empty;
            string destFolderName = string.Empty;
            string[] x = destinationUrl.Split("/");
            containerName = x[1]; //tsm
            destFolderName = x[2]; // omni , voya, paylocity
            pcssqldbconfigpayroll360devContext ps = new pcssqldbconfigpayroll360devContext();
            //var details = ps.GetProductByIDAsync(filename, inboundSourceSetup.FromEmailId);


            WebClient request = new WebClient();
            FtpWebRequest request1 = (FtpWebRequest)WebRequest.Create(inboundSourceSetup.SourceUrl + '/' + inboundSourceSetup.SourceFolderPath );//"ftp://mindcraft.in/"; destFolderName
            request1.Method = WebRequestMethods.Ftp.ListDirectory;
            request1.Credentials = new NetworkCredential(inboundSourceSetup.UserId, inboundSourceSetup.Password);
            FtpWebResponse response = (FtpWebResponse)request1.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string names = reader.ReadToEnd();
            reader.Close();
            response.Close();

            List<string> lstOfFiles = new List<string>(); // Get files from OMNI Folder
            lstOfFiles = names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> fileName = new List<string>();
            fileName = lstOfFiles.Where(fn => Path.GetExtension(fn) == ".TXT" || Path.GetExtension(fn) == ".xlsx" || Path.GetExtension(fn) == ".csv" || Path.GetExtension(fn) == ".json" || Path.GetExtension(fn) == ".xls")
                .Select(fn => Path.GetFileName(fn)).ToList();
            //.Select(fn => Path.GetFileNameWithoutExtension(fn)).ToList();

            request.Credentials = new NetworkCredential(inboundSourceSetup.UserId, inboundSourceSetup.Password);

            
            for (int j = 0; j < fileName.Count; j++)
            {
                var fileStatus = ps.InsertIntoFileReceived(fileName[j], inboundSourceSetup.FromEmailId);
                string url = inboundSourceSetup.SourceUrl + '/' + inboundSourceSetup.SourceFolderPath + '/' + fileName[j];// "VOYA_12042019_$27292.txt"; + destFolderName
                byte[] fileContents = request.DownloadData(url);
                var cloudStorageAccount = CloudStorageAccount.Parse(accessKey);
                var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
                var containerObject = cloudBlobClient.GetContainerReference(containerName + '/' + destFolderName);//+ destFolderName);
                var fileObject = containerObject.GetBlockBlobReference(fileName[j]);//filename

                string file_Type;
                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(fileName[j], out file_Type))
                {
                    file_Type = "application/octet-stream";
                }
                fileObject.Properties.ContentType = file_Type;
                fileObject.UploadFromByteArrayAsync(fileContents, 0, fileContents.Length);// (fileBytes, 0, fileBytes.Length);
                string fileUploadedURI = fileObject.Uri.AbsoluteUri;
            }

            /// Code For Log Analytics ///
            AzureLogAnalytics logAnalytics = new AzureLogAnalytics(
                workspaceId: logAnalyticsWorkspaceID,
                sharedKey: logAnalyticsAccessKey,
                logType: "ApplicationLog");

            logAnalytics.Post(JsonConvert.SerializeObject(
                         new
                         {
                             id = Guid.NewGuid().ToString(),
                             datetime = DateTime.Now,
                             message = destFolderName.ToUpper() + " File Uploaded Successfully - Junk Msg"
                         }));
            /// End Code for Log Analytics ///

            return destFolderName.ToUpper() + " File Uploaded Successfully";
        }
    }
}

