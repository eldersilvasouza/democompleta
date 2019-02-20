using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Domain.Interfaces.Services
{
    public interface IServiceBase <T> where T : class
    {

        Task SaveAsync(T obj);

        Task<T> GetAsync(int id);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T obj);

        Task DeleteAsync(T obj);





    }
}
