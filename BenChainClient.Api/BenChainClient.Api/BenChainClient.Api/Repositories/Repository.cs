using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using BenChainClient.Api.DbEntities;

namespace BenChainClient.Api.Repositories
{
  public abstract class Repository<T> : IRepository<T> where T : class, new()
  {
    protected odysseyEntities DbContext { get; } = new odysseyEntities();

    public virtual async Task<IEnumerable<T>> GetAll()
    {
      return await DbContext.Set<T>().ToListAsync().ConfigureAwait(false);
    }

    public virtual async Task<IEnumerable<T>> GetAllWhere(Expression<Func<T, bool>> predicate)
    {
      return await DbContext.Set<T>().Where(predicate).ToListAsync().ConfigureAwait(false);
    }

    public async Task<T> FindBy(Expression<Func<T, bool>> predicate)
    {
      return await DbContext.Set<T>().FirstOrDefaultAsync(predicate).ConfigureAwait(false);
    }

    public virtual void Create(T entity)
    {
      DbContext.Set<T>().Add(entity);
    }

    public virtual void Update(T entity)
    {
      DbContext.Entry(entity).State = EntityState.Modified;
    }

    public virtual void Delete(T entity)
    {
      DbContext.Set<T>().Remove(entity);
    }

    public virtual void Save(bool makeEvent, bool makeHistory, Guid? connectionId)
    {
      Save(makeEvent, makeHistory, connectionId, null, null);
    }

    public virtual void Save(bool makeEvent, bool makeHistory, Guid? connectionId, string moderator)
    {
      Save(makeEvent, makeHistory, connectionId, moderator, null);
    }

    public virtual void Save(bool makeEvent, bool makeHistory, Guid? connectionId, string moderator, string title)
    {
       DbContext.SaveChanges();
    }

    public void Dispose()
    {
      DbContext.Dispose();
    }
  }
}