using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.App.Interfaces
{
    public interface IAppServiceBase <T> where T : class
    {

        Task SaveAsync(T obj);

        Task<T> GetAsync(int id);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T obj);

        Task DeleteAsync(T obj);


    }
}
