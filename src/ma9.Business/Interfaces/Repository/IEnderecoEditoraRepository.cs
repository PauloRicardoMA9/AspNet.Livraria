using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Repository
{
    public interface IEnderecoEditoraRepository : IRepository<EnderecoEditora>
    {
        Task<EnderecoEditora> ObterEnderecoPorEditora(Guid editoraId);
    }
}
