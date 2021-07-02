using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class EnderecoFuncionarioRepository : Repository<EnderecoFuncionario>, IEnderecoFuncionarioRepository
    {
        public EnderecoFuncionarioRepository(ModelsDbContext context) : base(context) { }

        public async Task<EnderecoFuncionario> ObterEnderecoPorFuncionario(Guid funcionarioId)
        {
            return await Db.EnderecosFuncionarios.AsNoTracking().FirstOrDefaultAsync(funcionario => funcionario.Id == funcionarioId);
        }
    }
}
