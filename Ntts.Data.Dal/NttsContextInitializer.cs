using System.Data.Entity;
using Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public sealed class NttsContextInitializer : DropCreateDatabaseIfModelChanges<NttsContext>
    {
        protected override void Seed(NttsContext context) {
            AddActionTypes(context);
            AddFactDataT(context);
            AddFeedTypes(context);
            AddTaskActionBatchQueueStatuses(context);
            int defaultU
            int defaultUserId = AddDefaultUser(context);

            AddGetAllStockSymbolsTask(context, defaultUserId

        private void AddActionTypes(NttsContext context) {
            context.ActionTypes.Add(new ActionType {
                Name = "Feed"
            });

            context.ActionTypes.Add(new ActionType {
                Name = "Plugin"
            });

            context.SaveChanges();
        }

        private void AddFactDataTypes(NttsContext cDataTypes(NttsContext context) {
            context.FactDataTypes.Add(new ame = "String"
            });

            context.FactDataTypes.Add(new FactDataType {
                NDataType {
                Name = "Integer  context.FactDataTypes.Add(new FactDataType {
                Necimal"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "Ban"
            });

            context.FactDataTypes.Add(new FactDataType {
                Name = "DateT
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
            contex#t.SaveChanges();

            return defaultUser.Id;
        }
    }
}

        private void AddGetAllStockSymbolsTask(NttsContext context, int defaultUserId) {
            Feed getStockSymbolsForLetterFeed = new Feed {
                Name = "ADVFN_GetStockSymbolsForLetter",
                FeedTypeId = (int)FeedType.FeedTypeEnum.Scrape,
                Uri = "http://uk.advfn.com/exchanges/LSE/{letter}"
            };
            
            context.Feeds.Add(getStockSymbolsForLetterFeed);
            context.SaveChanges();
            
            Action getStockSymbolsForLetterAction = new Action {
                Name = "GetStockSymbolsForLetter",
                ActionTypeId = (int)ActionType.ActionTypeEnum.Feed,
                FeedId = getStockSymbolsForLetterFeed.Id
            };
            
            context.Actions.Add(getStockSymbolsForLetterAction);
            context.SaveChanges();

            ActionParameter getStockSymbolsForLetterActionParameter = new ActionParameter {
                ActionId = getStockSymbolsForLetterAction.Id,
                Name = "letter",
                DataTypeId = (int)DataType.DataTypeEnum.String
            };

            Task getStockSymbolsTask = new Task {
                Name = "GetAllStockSymbols",
                UserId = defaultUserId
            };

            context.ActionParameters.Add(getStockSymbolsForLetterActionParameter);
            context.Tasks.Add(getStockSymbolsTask);
            context.SaveChanges();

            TaskAction getStockSymbolsTaskAction = new TaskAction {
                TaskId = getStockSymbolsTask.Id,
                ActionId = getStockSymbolsForLetterAction.Id
            };

            context.TaskActions.Add(getStockSymbolsTaskAction);
            context.SaveChanges();

            string[] letters = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0" };

            for (int i = 0; i < letters.Length; i++) {
                TaskActionIteration getStockSymbolsTaskActionIteration = new TaskActionIteration {
                    IterationNumber = i,
                    TaskActionId = getStockSymbolsTaskAction.Id
                };

                context.TaskActionIterations.Add(getStockSymbolsTaskActionIteration);
                context.SaveChanges();

                TaskActionIterationParameter getStockSymbolsTaskActionIterationParameter = new TaskActionIterationParameter {
                    TaskActionIterationId = getStockSymbolsTaskActionIteration.Id,
                    ActionParameterId = getStockSymbolsForLetterActionParameter.Id,
                    Value = letters[i]
                };

                context.TaskActionIterationParameters.Add(getStockSymbolsTaskActionIterationParameter);
                context.SaveChanges();
            }
        }
    }
}
