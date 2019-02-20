using Demo.Data.Interfaces.Services;
using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repositories;
using Demo.Domain.Interfaces.Services;
using Demo.Domain.Services;

namespace Demo.Data.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;       


        public ClienteService(IClienteRepository clienteRepository)
            :base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }



    }
}
