using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Hris.Common.API
{
    public class HTTPWebRequestUtilities<T> where T : class
    {
        private readonly string _basePath;
        public HTTPWebRequestUtilities(string basePath)
        {
            _basePath = basePath;
        }

        private string ProcessRequest(string method, string url, object param = null, string token = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_basePath + url);
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);

            if (method != Global.Method.GET)
            {
                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = method;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(param));
                }
            }

            string ResponseString = "";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                ResponseString = streamReader.ReadToEnd();
            }

            return ResponseString;
        }

        public T Request(string method, string url, object param = null, string token = null)
        {
            try
            {
                var ResponseString = ProcessRequest(method, url, param, token);
                var result = JsonConvert.DeserializeObject<T>(ResponseString);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public IEnumerable<T> Requests(string method, string url, object param = null, string token = null)
        {
            try
            {
                var ResponseString = ProcessRequest(method, url, param, token);
                var result = JsonConvert.DeserializeObject<List<T>>(ResponseString);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
