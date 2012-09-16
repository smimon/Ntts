using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ntts.Data.Dal;
using Ntts.Data.Entities;

namespace Ntts.Test.ConsoleTest
{
    class Program
    {
        static void Main(string[] args) {
            NttsContext context = new NttsContext();
            
            User user = context.Users.Single(u => u.UserName.Equals("DefaultUser", StringComparison.OrdinalIgnoreCase));
        }
    }
}
