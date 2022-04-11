using JSON.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment();
            c1.Text = "salam";
            c1.LikeCount = 12;
            c1.Time = DateTime.Now;

            Comment c2 = new Comment();
            c2.Text = "necesen?";
            c2.LikeCount = 10;
            c2.Time = DateTime.Now;

            Comment c3 = new Comment();
            c3.Text = "yaxsisanmi?";
            c3.LikeCount = 9;
            c3.Time = DateTime.Now;

            Comment c4 = new Comment();
            c4.Text = "men yaxsiyam";
            c4.LikeCount = 7;
            c4.Time = DateTime.Now;

            User user1 = new User();
            user1.Name = "Mamed";
            user1.Surname = "Aliyev";
            user1.Age = 20;
            user1.Email = "Mamed@code.edu.az";

            User user2 = new User();
            user2.Name = "Isabala";
            user2.Surname = "Quliyev";
            user2.Age = 22;
            user2.Email = "Isabala@code.edu.az";

            user1.comments.Add(c1);
            user1.comments.Add(c2);

            user2.comments.Add(c3);
            user2.comments.Add(c4);

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);

           //Convert to string
            string UsersAsJson = JsonConvert.SerializeObject(users);
            

            //Write string to file as json without using json formatter because of visual studio
            StreamWriter sw = new StreamWriter(@"C:\Users\Hp\source\main.json");
            sw.WriteLine(UsersAsJson);
            sw.Close();

            //Read Json from file
            StreamReader sr = new StreamReader(@"C:\Users\Hp\source\main.json");
            string JsonStringi= sr.ReadToEnd();
            sr.Close();

            //Convert it to object list
            List<User> JsonAsObject= JsonConvert.DeserializeObject<List<User>>(JsonStringi);

            //Show on screen
            foreach(User item in JsonAsObject)
            {
                Console.WriteLine(item.Name+" ");
            }



        }
    }
}
