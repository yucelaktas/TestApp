using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp.Manager
{
    public class UserManager
    {
        private readonly IGenerateRandomItem _generateRandomItem;

        public UserManager(IGenerateRandomItem gRandomItem)
        {
            _generateRandomItem = gRandomItem;
        }

        public List<User> AddRandomUser(int listLenght)
        {

            List<User> userList = new List<User>();

            for (int i = 0; i < listLenght; i++)
            {
                User newUser = new User();

                newUser.Name = _generateRandomItem.GenerateRandomString();
                newUser.LastName = _generateRandomItem.GenerateRandomString();
                newUser.PhoneNumber = _generateRandomItem.generateRandomPhoneNumber();
                newUser.Age = _generateRandomItem.generateRandomAge();
                newUser.Role = _generateRandomItem.generateRandomRole();

                userList.Add(newUser);
            }

            return userList;
        }



    }
}

