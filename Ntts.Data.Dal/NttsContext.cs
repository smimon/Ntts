using System.Data.Entity;
using Ntts.Data.Entities;
using System.Data.Entity.ModelConfiguration.Convention;

namespace Ntts.Data.Dal
{
    public sealed class NttsContext : DbContext
    {
        public DbSet<Action> Actions { get; set; }
        public DbSet<ActionType> AcParameter> ActionParameter; set; }
        public DbSet<ActionType> ActionTypes { get; set; }
        public DbSet<Fact> FacDataType> FactDataTypes { get; set; }
        public DbSet<Fact> Facts { get; set; }        ublic DbSet<Feed> Feeds { get; set; }
        public DbSet<FeedType> FeedTypes { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Plugin> Plugins { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioStock> PortfolioStocks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockFact> StockFacts { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskAction> TaskActions { get; set; }
        public DbSet<TaskActionBatch> TaskActionBatches { get; set; }
        public DbSet<TaskActionBatchQueue> TaskActionBatchQueues { get; set; }
        public DbSet<TaskActionBatchQueueStatus> TaskActionBatchParameter> TaskActionBatchQueueParameter  public DbSet<TaskActionBatchQueueStatus> TaskActionBatchQueueStatuses { get; set; }
        public DbSet<User> Users { get; set; TaskActionIteration> TaskActionIterations { get; set; }
        public DbSet<TaskActionIterationParameter> TaskActionIterationParameter public DbSet<User> Users { get; set; }

        public NttsContext() {
            Database.SetInitializer<NttsContext>(new NttsContextInitializer());
        }
    }
}

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
