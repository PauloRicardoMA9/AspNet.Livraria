using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ModelsDbContext context) : base (context) { }

        public async Task<Funcionario> ObterFuncionarioEndereco(Guid funcionarioId)
        {
            return await Db.Funcionarios.AsNoTracking()
                .Include(funcionario => funcionario.EnderecoFuncionario)
                .FirstOrDefaultAsync(funcionario => funcionario.Id == funcionarioId);
        }
    }
}
