using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Business
{
    public class CommonRepository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> DbSet;
        protected DbContext Context;

        public CommonRepository(DbContext dataContext)
        {
            DbSet = dataContext.Set<T>();
            Context = dataContext;
            
        }

        #region IRepository<T> Members

        public int Insert(T entity)
        {
            DbSet.Add(entity);
            return Context.SaveChanges();


        }

        public int Delete(T entity)
        {
            DbSet.Remove(entity);
            return Context.SaveChanges();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);

        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public int Update(T entity)
        {
            var entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
                DbSet.Add(entity);
            else entry.State = EntityState.Modified;
            return Context.SaveChanges();
        }


        #endregion
    }
}

