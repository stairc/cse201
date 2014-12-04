using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace AppMap
{
    public static class ImageHelper
    {
        public static string GetWebsiteHTML(string urlAddress)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                string data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                return data;
            }

            return "";
        }

        internal static string GetAndroidImage(string HTML)
        {
            int index = HTML.IndexOf("cover-image");
            HTML = HTML.Substring(index + 18);
            index = HTML.IndexOf('"');
            string url = HTML.Substring(0, index);
            return url;
        }

        internal static string GetWindowsPhoneImage(string HTML)
        {
            string url = "";

            int index = HTML.IndexOf("appImage");
            HTML = HTML.Substring(index);

            index = HTML.IndexOf("src=");
            HTML = HTML.Substring(index + 5);

            index = HTML.IndexOf('"');
            url = HTML.Substring(0, index);

            return url;
        }

        internal static string GetAppleImage(string HTML)
        {
            string url = "";

            try
            {
                string searchStr = "width=" + ('"').ToString() + "175";
                int index = HTML.IndexOf(searchStr);
                HTML = HTML.Substring(index);
            
                index = HTML.IndexOf("src-swap=");
                HTML = HTML.Substring(index + 10);

                index = HTML.IndexOf('"');
                url = HTML.Substring(0, index);
            }
            catch (Exception)
            {
            }

            return url;
        }
    }
}