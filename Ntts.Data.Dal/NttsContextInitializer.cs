using System.Data.Entity;
using Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public sealed class NttsContextInitializer : DropCreateDatabaseIfModelChanges<NttsContext>
    {
        protected override void Seed(NttsContext context) {
            AddActionTypes(context);
            AddFactDataTypes(context);
            AddFeedTypes(context);
            AddTaskActionBatchQueueStatuses(context);
            int defaultUserId = AddDefaultUser(context);
        }

        private void AddActionTypes(NttsContext context) {
            context.ActionTypes.Add(new ActionType {
                Name = "Feed"
            });

            context.ActionTypes.Add(new ActionType {
                Name = "Plugin"
            });

            context.SaveChanges();
        }

        private void AddFactDataTypes(NttsContext context) {
            context.FactDataTypes.Add(new FactDataType {
                Name = "String"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "Integer"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "Decimal"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "Boolean"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "DateTime"
            });

            context.SaveChanges();
        }

        private void AddFeedTypes(NttsContext context) {
            context.FeedTypes.Add(new FeedType {
                Name = "Scrape"
            });

            context.SaveChanges();
        }

        private void AddTaskActionBatchQueueStatuses(NttsContext context) {
            context.TaskActionBatchQueueStatuses.Add(new TaskActionBatchQueueStatus {
                Name = "Queued"
            });

            context.TaskActionBatchQueueStatuses.Add(new TaskActionBatchQueueStatus {
                Name = "In Progress"
            });

            context.TaskActionBatchQueueStatuses.Add(new TaskActionBatchQueueStatus {
                Name = "Complete"
            });

            context.TaskActionBatchQueueStatuses.Add(new TaskActionBatchQueueStatus {
                Name = "Error"
            });
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
    }
}
