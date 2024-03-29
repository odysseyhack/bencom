using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using BenChainClient.Api.Repositories;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BenChainClient.Api.Repositories.Tests
{
    /// <summary>This class contains parameterized unit tests for Repository`1</summary>
    [TestClass]
    [PexClass(typeof(Repository<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RepositoryTTest
    {

    /// <summary>Test stub for GetAll()</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public Task<IEnumerable<T>> GetAllTest<T>([PexAssumeNotNull]Repository<T> target)
        where T : class, new()
    {
      Task<IEnumerable<T>> result = target.GetAll();
      return result;
    }

    /// <summary>Test stub for GetAllWhere(Expression`1&lt;Func`2&lt;!0,Boolean&gt;&gt;)</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public Task<IEnumerable<T>> GetAllWhereTest<T>([PexAssumeNotNull]Repository<T> target, Expression<Func<T, bool>> predicate)
        where T : class, new()
    {
      Task<IEnumerable<T>> result = target.GetAllWhere(predicate);
      return result;
    }

    /// <summary>Test stub for FindBy(Expression`1&lt;Func`2&lt;!0,Boolean&gt;&gt;)</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public Task<T> FindByTest<T>([PexAssumeNotNull]Repository<T> target, Expression<Func<T, bool>> predicate)
        where T : class, new()
    {
      Task<T> result = target.FindBy(predicate);
      return result;
    }

    /// <summary>Test stub for Create(!0)</summary>
    [PexGenericArguments(typeof(object))]
    [PexMethod]
    public void CreateTest<T>([PexAssumeNotNull]Repository<T> target, T entity)
        where T : class, new()
    {
      target.Create(entity);
    }
  }
}
