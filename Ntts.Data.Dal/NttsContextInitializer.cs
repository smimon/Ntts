using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public class NttsContextInitializer : DropCreateDatabaseIfModelChanges<NttsContext>
    {
        protected override void Seed(NttsContext context) {
            int defaultUserId = AddDefaultUser(context);
            int defaultPortfolioId = AddDefaultPortfolio(context, defaultUserId);
        }

        private int AddDefaultUser(NttsContext context) {
            User defaultUser = new User {
                UserName = "DefaultUser",
                PasswordHash = ""
            };

            context.Users.Add(defaultUser);
            context.SaveChanges();

            return defaultUser.Id;
        }

        private int AddDefaultPortfolio(NttsContext context, int defaultUserId) {
            Portfolio defaultPortfolio = new Portfolio {
                Name = "Default Portfolio",
                UserId = defaultUserId
            };

            context.Portfolios.Add(defaultPortfolio);
            context.SaveChanges();

            return defaultPortfolio.Id;
        }
    }
}
