using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ModelsDbContext context) : base(context) { }

        public async Task<Cliente> ObterClienteEndereco(Guid id)
        {
            return await Db.Clientes.AsNoTracking()
                .Include(cliente => cliente.EnderecoCliente)
                .FirstOrDefaultAsync(cliente => cliente.Id == id);
        }
    }
}
