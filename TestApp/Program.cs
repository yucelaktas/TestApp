using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestApp.Manager;
using TestApp.Model;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

           UserManager uManager = new UserManager(new GenerateRandomItem());

            List<User> users=uManager.AddRandomUser(5);

            foreach (var user in users)
            {
                Console.WriteLine(user.Name+" "+user.LastName+" "+user.Age+" "+user.PhoneNumber+" "+user.Role);
            }

            Console.ReadLine();
        }
    }
}
