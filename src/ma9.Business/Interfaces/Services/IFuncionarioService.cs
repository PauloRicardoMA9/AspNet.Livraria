using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Services
{
    public interface IFuncionarioService : IDisposable
    {
        Task Adicionar(Funcionario funcionario);
        Task Atualizar(Funcionario funcionario);
        Task Remover(Guid id);
        Task AtualizarEndereco(EnderecoFuncionario enderecoFuncionario);
    }
}
