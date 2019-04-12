using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace BenChainClient.Api.Repositories
{
  public interface IRepository<T> : IDisposable
  {
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> GetAllWhere(Expression<Func<T, bool>> predicate);
    Task<T> FindBy(Expression<Func<T, bool>> predicate);
    void Create(T entity);
    void Delete(T entity);
    void Update(T entity);
    void Save(bool makeUserEvent, bool makeHistory, Guid? connectionId);
    void Save(bool makeUserEvent, bool makeHistory, Guid? connectionId, string moderator);
    void Save(bool makeUserEvent, bool makeHistory, Guid? connectionId, string moderator, string title);
  }
}