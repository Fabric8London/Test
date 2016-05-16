using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class PackagesBiz
    {
        public static string GetAllPackagesJson()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://test.client.fabric8.co.uk/api/packages/");
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                return string.Empty;
            }
        }
    }
}
