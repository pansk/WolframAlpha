using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using WolframAlpha;

namespace WolframAlphaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestUriString = string.Format("http://api.wolframalpha.com/v2/query?input={0}&appid=<key>", Uri.EscapeUriString("History of weather forecast"));
            var responseStream = WebRequest.Create(requestUriString)
                .GetResponse()
                .GetResponseStream();
            var responseString = new StreamReader(responseStream).ReadToEnd();
            var deser = new XmlSerializer(typeof(QueryResult)).Deserialize(new StringReader(responseString)) as QueryResult;
		}
    }
}
