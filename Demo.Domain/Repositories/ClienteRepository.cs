using Demo.Data.Context;
using Demo.Domain.Entities;
using Demo.Domain.Interfaces.Repositories;

namespace Demo.Domain.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente> , IClienteRepository
    {
        public ClienteRepository(DemoContext context) : base(context)
        { }


    }
}
