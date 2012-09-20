using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Ntts.Data.EntDal.Interfacesusing Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public class EntityManager<TEntity>
        where TEntity : IdentityEntityBase
    {
        private Methotected IContextProvider ContextProvider { get; set; }

        public EntityManager(IContextProvider contextProvider) {
            ContextProvider = contextProvider;
        }

        public TEntity GetById(DbContext context, int id) {
            return (TEntity)context.Set(typeof(TEntity)).Find(id);            
        }

        public int Add(DbContext context, TEntity entity) {
            GetDbSet(context).Add(entity);

            context.SaveChanges();

            return entity.Id;
        }

        public void Delete(DbContext context, TEntity entity) {
            GetDbSet(context).Remove(entity);

            context.SaveChanges();
        }

        protected DbContext GetNttsContext() {
            return ContextProvider.GetNttsContext();
        }

        protected DbSet GetDbSet(DbContext context) {
            return context.Set(typeof(TEntity));
        }
    }
}
