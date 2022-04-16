using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mail address which you want to send message");
            string email= Console.ReadLine();
            Console.WriteLine("Enter mail subject");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter mail message");
            string message= Console.ReadLine();

            try
            {
                Mail.Send(email, subject, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
