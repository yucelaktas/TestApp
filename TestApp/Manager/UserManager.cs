using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp.Manager
{
    public class UserManager
    {
        public List<User> AddRandomUser(int listLenght)
        {
            List<User> userList = new List<User>();

            for (int i = 0; i < listLenght; i++)
            {
                User newUser = new User();

                newUser.Name = generateRandomString();
                newUser.LastName = generateRandomString();
                newUser.PhoneNumber = generateRandomPhoneNumber();
                newUser.Age = generateRandomAge();
                newUser.Role = generateRandomRole();

                userList.Add(newUser);
            }

            return userList;
        }

        private string generateRandomString()
        {
            const string CHARS = "abcdefghijklmnoprstvyzwx";

            Random r = new Random();

            int arrayLenght = r.Next(4, 9);

            char[] name = new char[arrayLenght];

            for (int j = 0; j < name.Length; j++)

                name[j] = CHARS[r.Next(0, 23)];

            return name.ToString();
        }

        private int generateRandomPhoneNumber()
        {
            const string NUMBERS = "1234567890";

            Random r = new Random();

            int[] phoneNumber = new int[10];

            for (int j = 0; j < phoneNumber.Length; j++)

                phoneNumber[j] = NUMBERS[r.Next(0, 9)];

            return Convert.ToInt32(phoneNumber);

        }

        private short generateRandomAge()
        {
            const string NUMBERS = "1234567890";

            Random r = new Random();

            int[] phoneNumber = new int[2];

            for (int j = 0; j < phoneNumber.Length; j++)

                phoneNumber[j] = NUMBERS[r.Next(0, 9)];

            return Convert.ToInt16(phoneNumber);
        }

        private Roles generateRandomRole()
        {
            Random r = new Random();

            return (Roles)r.Next(Enum.GetNames(typeof(Roles)).Length);

        }
    }
}

