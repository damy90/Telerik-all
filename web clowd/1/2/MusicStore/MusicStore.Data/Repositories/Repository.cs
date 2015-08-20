using System;
using System.Data.Entity;
using System.Linq;

namespace MusicStore.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private IDbContext context;
        private IDbSet<T> set;

        public Repository()
            : this(new MusicStoreContext())
        {
            
        }

        public Repository(IDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public IQueryable<T> All()
        {
            return this.set;
        }

        public void Add(T entity)
        {
            ChangeEntityState(entity, EntityState.Added);
        }

        private void ChangeEntityState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }

        public void Update(T entity)
        {
            ChangeEntityState(entity, EntityState.Modified);
        }

        public void Delete(T entity)
        {
            ChangeEntityState(entity, EntityState.Deleted);
        }

        public void Detach(T entity)
        {
            ChangeEntityState(entity, EntityState.Detached);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
