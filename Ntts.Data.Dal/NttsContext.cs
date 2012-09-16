using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public class NttsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        public NttsContext() {
            Database.SetInitializer<NttsContext>(new NttsContextInitializer());
        }
    }
}
