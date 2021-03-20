using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orchtech.DotNetTask.Common.Repository
{
    public class Repository<TDbContext> : IRepository where TDbContext : DbContext
    {
        protected TDbContext dbContext;

        public Repository(TDbContext context)
        {
            dbContext = context;
        }

        public async Task CreateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await this.dbContext.Set<T>().ToListAsync();
        }


        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Update(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task<T> Find<T>(Guid id) where T : class
        {
            return await this.dbContext.Set<T>().FindAsync(id);
        }
    }

}