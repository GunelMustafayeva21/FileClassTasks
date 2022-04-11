using ConsoleApp25.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;



namespace ConsoleApp25
{
    internal class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(@"https://jsonplaceholder.typicode.com/posts").Result;
            Console.WriteLine(response);


            //List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(response);

            //foreach (var item in posts)
            //{
            //    Console.WriteLine(item.title);
            //}



        }
    }
}
