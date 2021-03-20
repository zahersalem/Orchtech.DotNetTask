using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orchtech.DotNetTask.Common.Repository
{
    public interface IRepository
    {
        Task<List<T>> GetAll<T>() where T : class;
        Task<T> Find<T>(Guid id) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}