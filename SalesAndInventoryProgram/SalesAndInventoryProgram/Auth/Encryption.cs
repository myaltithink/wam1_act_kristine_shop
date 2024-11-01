using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndInventoryProgram.Auth
{
    internal class Encryption
    {

        public string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 13);
        }

        public bool PasswordMatch(string encrypted, string raw)
        {
            return BCrypt.Net.BCrypt.Verify(raw, encrypted);
        }

    }
}
