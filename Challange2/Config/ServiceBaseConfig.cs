using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Challange2.Config
{
    public class ServiceBaseConfig
    {

        public dynamic getData(string responseString)
        {
            return Newtonsoft.Json.Linq.JObject.Parse(responseString.ToString().Replace(@"\", ""));
        }

        public string getRequest(string requestUrl)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            var getResponse = (HttpWebResponse)request.GetResponse();
            return new StreamReader(getResponse.GetResponseStream()).ReadToEnd();
        }

    }
}
