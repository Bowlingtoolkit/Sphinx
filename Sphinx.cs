using System.Net;
using System.IO;

namespace Sphinx
{
    public class Request 
    {
        /// <summary>
        /// to make post request
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="data">The data you wanna send in the request, you can use Converter.JSON/Converter.XML to convert object/xml to string</param>
        /// <param name="contentType">Content Type, JSON/XML</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Post(string url, string data, ContentType contentType, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = contentType == ContentType.json ? "application/json" : contentType == ContentType.xml ? "application/xml" : "application/json";
            httpWebRequest.Method = "POST";
            if (headers != null) httpWebRequest.Headers = headers;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
        /// <summary>
        /// to make get request to a specific site
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Get(string url, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            if (headers != null) httpWebRequest.Headers = headers;

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
        /// <summary>
        /// to make patch request to a specific site
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="data">The data you wanna send in the request, you can use Converter.JSON/Converter.XML to convert object/xml to string</param>
        /// <param name="contentType">Content Type, JSON/XML</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Patch(string url, string data, ContentType contentType, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = contentType == ContentType.json ? "application/json" : contentType == ContentType.xml ? "application/xml" : "application/json";
            httpWebRequest.Method = "PATCH";
            if (headers != null) httpWebRequest.Headers = headers;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
        /// <summary>
        /// to make put request to a specific site
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="data">The data you wanna send in the request, you can use Converter.JSON/Converter.XML to convert object/xml to string</param>
        /// <param name="contentType">Content Type, JSON/XML</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Put(string url, string data = null, ContentType contentType = ContentType.json, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = contentType == ContentType.json ? "application/json" : contentType == ContentType.xml ? "application/xml" : "application/json";
            httpWebRequest.Method = "PUT";
            if (headers != null) httpWebRequest.Headers = headers;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
        /// <summary>
        /// to make head request to a specific site
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Head(string url, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "HEAD";
            if (headers != null) httpWebRequest.Headers = headers;

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
        /// <summary>
        /// to make delete request to a specific site
        /// </summary>
        /// <param name="url">The website url</param>
        /// <param name="headers">Request Headers</param>
        /// <returns>Properties with the body & status code</returns>
        public static RequestResponse Delete(string url, WebHeaderCollection headers = null)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "DELETE";
            if (headers != null) httpWebRequest.Headers = headers;

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                RequestResponse Response = new RequestResponse();
                Response.Body = result;
                Response.StatusCode = (int)httpResponse.StatusCode;
                return Response;
            }
        }
    }
}
