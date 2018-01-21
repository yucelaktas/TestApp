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
        string generateRandomPhoneNumber();

        short generateRandomAge();

        Roles generateRandomRole();

        string GenerateRandomString();
    }
}
