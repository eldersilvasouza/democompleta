using Demo.Domain.Interfaces.Repositories;
using Demo.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class                  
    {

        private readonly IRepositoryBase<T> _repository;


        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public async Task DeleteAsync(T obj)
        {
            await _repository.DeleteAsync(obj);
        }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _repository.GetAsync(id);

        }

        public async Task SaveAsync(T obj)
        {
            await _repository.SaveAsync(obj);
        }

        public async Task UpdateAsync(T obj)
        {
            await _repository.UpdateAsync(obj);
        }
    }
}
