using Demo.App.Interfaces;
using Demo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Demo.App
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {

        private readonly IServiceBase<T> _serviceBase;
                     

        public AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }
                     



        public async Task DeleteAsync(T obj)
        {
            await _serviceBase.DeleteAsync(obj);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _serviceBase.GetAsync(id);
        }

        public async Task SaveAsync(T obj)
        {
            await _serviceBase.SaveAsync(obj);
        }

        public async Task UpdateAsync(T obj)
        {
            await _serviceBase.UpdateAsync(obj);
        }
    }
}
