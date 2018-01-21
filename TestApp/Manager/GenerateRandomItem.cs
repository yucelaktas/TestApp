using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp.Manager
{
    public class GenerateRandomItem : IGenerateRandomItem
    {
        public string generateRandomPhoneNumber()
        {

            Random r = new Random();

            string phoneNum = "0";

            for (int i = 0; i < 9; i++)
            {
                phoneNum += r.Next(0, 9).ToString();
            }

            return phoneNum;

        }

        public short generateRandomAge()
        {
            Random r = new Random();

            int ageInt = r.Next(0, 90);

            short age = Convert.ToInt16(ageInt);

            return age;

        }

        public Roles generateRandomRole()
        {
            Random r = new Random();

            return (Roles)r.Next(Enum.GetNames(typeof(Roles)).Length);

        }

        public string GenerateRandomString()
        {
            const string CHARS = "abcdefghijklmnoprstvyzwx";

            Random r = new Random();

            int arrayLenght = r.Next(4, 9);

            char[] nameChar = new char[arrayLenght];

            for (int j = 0; j < nameChar.Length; j++)

                nameChar[j] = CHARS[r.Next(0, 23)];

            string name = new string(nameChar);

            Thread.Sleep(100);

            return name;
        }
    }
}

