

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Domain.Interfaces.Repositories
{
   public  interface IRepositoryBase <T> where T : class
    {
        Task SaveAsync(T obj);

        Task<T> GetAsync(int id);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T obj);

        Task DeleteAsync(T obj);







    }
}
