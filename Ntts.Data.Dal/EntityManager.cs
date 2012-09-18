using System.Data.Entity;
using System.Linq;
using System.Reflection;
using Ntts.Data.Entities;

namespace Ntts.Data.Dal
{
    public class EntityMManager<TEntity>
        where TEntity : IdentityEntityBase
    {
        private MethodInfo _miSet;
        
        protected NttsContext NttsContext { get; set; }

        public EntityManager(NttsContext nttsContext) {
            NttsContext = nttsContext;
        }

        public TEntity GetById(int id) {
            return (TEntity)GetDbSet().Find(id);
        }

        public int Add(TEntity entity) {
            GetDbSet().Add(entity);

            NttsContext.SaveChanges();

            return entity.Id;
        }

        public void Delete(TEntity entity) {
            GetDbSet().Remove(entity);

            NttsContext.SaveChanges();
        }

        public void Update(TEntity entity) {
            NttsContext.SaveChanges();
        }

        private DbSet<TEntity> GetDbSet() {
            if (_miSet == null) {
                _miSet = typeof(DbContext).GetMethods().Single(m => m.Name.Equals("Set") && m.IsGenericMethod);
                _miSet = _miSet.MakeGenericMethod(typeof(TEntity));
            }

            return (DbSet<TEntity>)_miSet.Invoke(NttsContext, null);
        }
    }
}
