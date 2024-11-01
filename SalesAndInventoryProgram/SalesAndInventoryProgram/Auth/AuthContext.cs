using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndInventoryProgram.Auth
{
    internal class AuthContext
    {

        public string username { get; set; }

        public bool isOwner { get; set; } = false;

    }
}
