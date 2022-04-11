using FileClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter link of site and name of file which you want to download your site consequently");
            SiteHtmlDownloader.Download(Console.ReadLine(), Console.ReadLine());
        }
    }
}
