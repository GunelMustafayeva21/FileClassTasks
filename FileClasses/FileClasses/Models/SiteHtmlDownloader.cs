using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FileClasses.Models
{
    public static class SiteHtmlDownloader
    {
        
        public static void Download(string SiteLink, string FileName)
        {
            HttpClient httpClient = new HttpClient();
            string content = httpClient.GetStringAsync(SiteLink).Result;

            StreamWriter sw = new StreamWriter(@"C:\Users\Hp\source\" + FileName + ".html");
            sw.WriteLine(content);
            sw.Close();
        }
    }
}
