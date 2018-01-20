using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp.Manager
{
    public interface IGenerateRandomItem
    {
        int generateRandomPhoneNumber();

        short generateRandomAge();

        Roles generateRandomRole();

        string GenerateRandomString();
    }
}
