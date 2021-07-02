using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Services
{
    public interface IEditoraService : IDisposable
    {
        Task Adicionar(Editora editora);
        Task Atualizar(Editora editora);
        Task Remover(Guid id);
        Task AtualizarEndereco(EnderecoEditora enderecoEditora);
    }
}
