using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class EnderecoClienteRepository : Repository<EnderecoCliente>, IEnderecoClienteRepository
    {
        public EnderecoClienteRepository(ModelsDbContext context) : base(context) { }

        public async Task<EnderecoCliente> ObterEnderecoPorCliente(Guid clienteId)
        {
            return await Db.EnderecosClientes.AsNoTracking().FirstOrDefaultAsync(cliente => cliente.Id == clienteId);
        }
    }
}
