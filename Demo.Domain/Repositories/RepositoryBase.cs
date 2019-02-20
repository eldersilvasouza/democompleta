using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.Data.Context;
using System;
using Demo.Domain.Interfaces;
using Demo.Domain.Interfaces.Repositories;

namespace Demo.Domain.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {

        private DemoContext Context { get; set; }


        public RepositoryBase(DemoContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));

        }


        public async Task DeleteAsync(T obj)
        {
            this.Context.Set<T>().Remove(obj);
            await this.Context.SaveChangesAsync();
            
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await this.Context.Set<T>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveAsync(T obj)
        {
            this.Context.Set<T>().Add(obj);
            await this.Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T obj)
        {
            this.Context.Entry(obj).State = EntityState.Modified;
            await this.Context.SaveChangesAsync();
        }

        //public void Dispose()
        //{
        //     this.Context.Dispose();
        //}
    }
}
