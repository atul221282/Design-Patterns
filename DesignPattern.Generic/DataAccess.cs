using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    public class EmployeeDb : DbContext
    {
        public DbSet<Employee> Employess { get; set; }
    }

    public interface IReadOnlyRepository<out T> : IDisposable
    {
        T FindById(int id);
        IQueryable<T> FindAll();
    }

    public interface IWriteOnlyRepository<in T> : IDisposable
    {
        void Add(T entity);
        void Delete(T Entity);
        int Commit();
    }

    public interface IRepository<T> : IReadOnlyRepository<T>, IWriteOnlyRepository<T>, IDisposable
    {
    }

    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        DbContext _ctx;
        DbSet<T> _set;
        public SqlRepository(DbContext ctx)
        {
            _ctx = ctx;
            _set = _ctx.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity.IsValid())
                _set.Add(entity);
        }

        public int Commit()
        {
            return _ctx.SaveChanges();
        }

        public void Delete(T Entity)
        {
            _set.Remove(Entity);
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public IQueryable<T> FindAll()
        {
            return _set;
        }

        public T FindById(int id)
        {
            return _set.Find(id);
        }
    }
}
