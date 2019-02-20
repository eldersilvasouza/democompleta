using Demo.App.Interfaces;
using Demo.Data.Interfaces.Services;
using Demo.Domain.Entities;

namespace Demo.App
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;


        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }
            
    }
}
