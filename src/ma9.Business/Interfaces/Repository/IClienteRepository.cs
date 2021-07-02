using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> ObterClienteEndereco(Guid id);
    }
}
