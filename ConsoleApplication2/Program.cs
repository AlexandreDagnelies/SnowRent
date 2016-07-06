using ConsoleApplication2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        private static User user;

        static void Main(string[] args)
        {
            user = new User();
            Console.WriteLine(user);
            user.Id = 18;
            Console.WriteLine(user.Id);

            User user2 = new User(14, "michel", "jacky", new DateTime(2001, 4, 12), false);
            Console.WriteLine(user2);

            Console.ReadLine();

        }
    }
}
