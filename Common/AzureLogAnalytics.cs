//using ExternalFTPInjestion.Common;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Reflection;
//using System.Security.Cryptography;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace LogAnalytics.Client
//{
//    public class AzureLogAnalytics : ILogAnalyticsClient
//    {
//        private string WorkspaceId { get; set; }
//        private string SharedKey { get; set; }
//        private string RequestBaseUrl { get; set; }

//        // You might want to implement your own disposing patterns, or use a static httpClient instead. Use cases vary depending on how you'd be using the code.
//        private readonly HttpClient httpClient;

//        public AzureLogAnalytics(string workspaceId, string sharedKey, String logType, String apiVersion = "2015-03-20")
//        {
//            if (string.IsNullOrEmpty(workspaceId))
//                throw new ArgumentNullException(nameof(workspaceId), "workspaceId cannot be null or empty");

//            if (string.IsNullOrEmpty(sharedKey))
//                throw new ArgumentNullException(nameof(sharedKey), "sharedKey cannot be null or empty");

//            WorkspaceId = workspaceId;
//            SharedKey = sharedKey;
//            RequestBaseUrl = $"https://{WorkspaceId}.ods.opinsights.azure.com/api/logs?api-version=2015-03-20";

//            httpClient = new HttpClient();
//        }

//        public async Task SendLogEntry<T>(T entity, string logType)
//        {
//            #region Argument validation

//            if (entity == null)
//                throw new NullReferenceException("parameter 'entity' cannot be null");

//            if (logType.Length > 100)
//                throw new ArgumentOutOfRangeException(nameof(logType), logType.Length, "The size limit for this parameter is 100 characters.");

//            if (!IsAlphaOnly(logType))
//                throw new ArgumentOutOfRangeException(nameof(logType), logType, "Log-Type can only contain alpha characters. It does not support numerics or special characters.");

//            ValidatePropertyTypes(entity);

//            #endregion

//            List<T> list = new List<T> { entity };
//            await SendLogEntries(list, logType).ConfigureAwait(false);
//        }

//        public async Task SendLogEntries<T>(List<T> entities, string logType)
//        {
//            #region Argument validation

//            if (entities == null)
//                throw new NullReferenceException("parameter 'entities' cannot be null");

//            if (logType.Length > 100)
//                throw new ArgumentOutOfRangeException(nameof(logType), logType.Length, "The size limit for this parameter is 100 characters.");

//            if (!IsAlphaOnly(logType))
//                throw new ArgumentOutOfRangeException(nameof(logType), logType, "Log-Type can only contain alpha characters. It does not support numerics or special characters.");

//            foreach (var entity in entities)
//                ValidatePropertyTypes(entity);

//            #endregion

//            var dateTimeNow = DateTime.UtcNow.ToString("r");

//            var entityAsJson = JsonConvert.SerializeObject(entities);
//            var authSignature = GetAuthSignature(entityAsJson, dateTimeNow);

//            httpClient.DefaultRequestHeaders.Clear();
//            httpClient.DefaultRequestHeaders.Add("Authorization", authSignature);
//            httpClient.DefaultRequestHeaders.Add("Log-Type", logType);
//            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
//            httpClient.DefaultRequestHeaders.Add("x-ms-date", dateTimeNow);
//            httpClient.DefaultRequestHeaders.Add("time-generated-field", ""); // if we want to extend this in the future to support custom date fields from the entity etc.

//            HttpContent httpContent = new StringContent(entityAsJson, Encoding.UTF8);
//            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
//            HttpResponseMessage response = await httpClient.PostAsync(new Uri(RequestBaseUrl), httpContent).ConfigureAwait(false);

//            HttpContent responseContent = response.Content;
//            string result = await responseContent.ReadAsStringAsync().ConfigureAwait(false);
//            // helpful todo: if you want to return the data, this might be a good place to start working with it...
//        }

//        #region Helpers

//        private string GetAuthSignature(string serializedJsonObject, string dateString)
//        {
//            string stringToSign = $"POST\n{serializedJsonObject.Length}\napplication/json\nx-ms-date:{dateString}\n/api/logs";
//            string signedString;

//            var encoding = new ASCIIEncoding();
//            var sharedKeyBytes = Convert.FromBase64String(SharedKey);
//            var stringToSignBytes = encoding.GetBytes(stringToSign);
//            using (var hmacsha256Encryption = new HMACSHA256(sharedKeyBytes))
//            {
//                var hashBytes = hmacsha256Encryption.ComputeHash(stringToSignBytes);
//                signedString = Convert.ToBase64String(hashBytes);
//            }

//            return $"SharedKey {WorkspaceId}:{signedString}";
//        }
//        private bool IsAlphaOnly(string str)
//        {
//            return Regex.IsMatch(str, @"^[a-zA-Z]+$");
//        }
//        private void ValidatePropertyTypes<T>(T entity)
//        {
//            // as of 2018-10-30, the allowed property types for log analytics, as defined here (https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-data-collector-api#record-type-and-properties) are: string, bool, double, datetime, guid.
//            // anything else will be throwing an exception here.
//            foreach (PropertyInfo propertyInfo in entity.GetType().GetProperties())
//            {
//                if (propertyInfo.PropertyType != typeof(string) &&
//                    propertyInfo.PropertyType != typeof(bool) &&
//                    propertyInfo.PropertyType != typeof(double) &&
//                    propertyInfo.PropertyType != typeof(DateTime) &&
//                    propertyInfo.PropertyType != typeof(Guid))
//                {
//                    throw new ArgumentOutOfRangeException($"Property '{propertyInfo.Name}' of entity with type '{entity.GetType()}' is not one of the valid properties. Valid properties are String, Boolean, Double, DateTime, Guid.");
//                }
//            }
//        }

//        #endregion
//    }
//}

using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExternalFTPInjestion.Common
{
    public class AzureLogAnalytics
    {
        public String WorkspaceId { get; set; }
        public String SharedKey { get; set; }
        public String ApiVersion { get; set; }
        public String LogType { get; set; }
        public AzureLogAnalytics(String workspaceId, String sharedKey, String logType, String apiVersion = "2016-04-01")
        {
            this.WorkspaceId = workspaceId;
            this.SharedKey = sharedKey;
            this.LogType = logType;
            this.ApiVersion = apiVersion;
        }

        //[HttpPost]
        public void Post(string json)
        {
            string requestUriString = $"https://{WorkspaceId}.ods.opinsights.azure.com/api/logs?api-version={ApiVersion}";
            DateTime dateTime = DateTime.UtcNow;
            string dateString = dateTime.ToString("r");
            string signature = GetSignature("POST", json.Length, "application/json", dateString, "/api/logs");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.Headers["Log-Type"] = LogType;
            request.Headers["x-ms-date"] = dateString;
            request.Headers["Authorization"] = signature;
            byte[] content = Encoding.UTF8.GetBytes(json);
            using (Stream requestStreamAsync = request.GetRequestStream())
            {
                requestStreamAsync.Write(content, 0, content.Length);
            }


            using (HttpWebResponse responseAsync = (HttpWebResponse)request.GetResponse())
            {
                if (responseAsync.StatusCode != HttpStatusCode.OK && responseAsync.StatusCode != HttpStatusCode.Accepted)
                {
                    Stream responseStream = responseAsync.GetResponseStream();
                    if (responseStream != null)
                    {
                        using (StreamReader streamReader = new StreamReader(responseStream))
                        {
                            throw new Exception(streamReader.ReadToEnd());
                        }
                    }
                }
            }
        }

        private string GetSignature(string method, int contentLength, string contentType, string date, string resource)
        {
            string message = $"{method}\n{contentLength}\n{contentType}\nx-ms-date:{date}\n{resource}";
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            using (HMACSHA256 encryptor = new HMACSHA256(Convert.FromBase64String(SharedKey)))
            {
                return $"SharedKey {WorkspaceId}:{Convert.ToBase64String(encryptor.ComputeHash(bytes))}";
            }
        }

        //[HttpPost]
        //public async void Post(string json)
        //{ 
        //    try
        //    {
        //        string url = "https://" + WorkspaceId + ".ods.opinsights.azure.com/api/logs?api-version=2016-04-01";
        //        var datestring = DateTime.UtcNow.ToString("r");
        //        var jsonBytes = Encoding.UTF8.GetBytes(json);
        //        string stringToHash = "POST\n" + jsonBytes.Length + "\napplication/json\n" + "x-ms-date:" + datestring + "\n/api/logs";
        //        string hashedString = BuildSignature(stringToHash, SharedKey);
        //        string signature = "SharedKey " + WorkspaceId + ":" + hashedString;
        //        System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        //        client.DefaultRequestHeaders.Add("Accept", "application/json");
        //        client.DefaultRequestHeaders.Add("Authorization", signature); //SharedKey af7dbf3f-a87e-4483-ba51-0036f6debf7f:RkTsX3FXbCI49hyhhT95HpFZvQd8FLrvsmyC9xPl/cc=
        //        client.DefaultRequestHeaders.Add("x-ms-date", datestring);

        //        System.Net.Http.HttpContent httpContent = new StringContent(json, Encoding.UTF8);
        //        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //        Task<System.Net.Http.HttpResponseMessage> response = client.PostAsync(new Uri(url), httpContent);

        //        System.Net.Http.HttpContent responseContent = response.Result.Content;
        //        string result = responseContent.ReadAsStringAsync().Result;
        //        //Console.WriteLine("Return Result: " + result);
        //    }
        //    catch (Exception excep)
        //    {
        //        Console.WriteLine("API Post Exception: " + excep.Message);
        //    }
        //}

        //public static string BuildSignature(string message, string secret)
        //{
        //    var encoding = new System.Text.ASCIIEncoding();
        //    byte[] keyByte = Convert.FromBase64String(secret);
        //    byte[] messageBytes = encoding.GetBytes(message);
        //    using (var hmacsha256 = new HMACSHA256(keyByte))
        //    {
        //        byte[] hash = hmacsha256.ComputeHash(messageBytes);
        //        return Convert.ToBase64String(hash);
        //    }
        //}


    }
}
