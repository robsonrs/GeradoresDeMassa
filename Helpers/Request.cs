using System;
using System.Net;

namespace GeradoresDeMassa.Helpers
{
    public class Request
    {
        private static readonly HttpClient client = new HttpClient();
        public static string Get(string url)
        {
            string retorno = string.Empty;

            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();
            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            
            return data;
        }
    }
}