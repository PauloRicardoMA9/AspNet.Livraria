using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Repository
{
    public interface IEnderecoFuncionarioRepository : IRepository<EnderecoFuncionario>
    {
        Task<EnderecoFuncionario> ObterEnderecoPorFuncionario(Guid funcionarioId);
    }
}
