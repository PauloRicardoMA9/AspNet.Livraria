using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Repository
{
    public interface IEditoraRepository : IRepository<Editora>
    {
        Task<Editora> ObterEditoraEndereco(Guid editoraId);
        Task<Editora> ObterEditoraLivrosEndereco(Guid editoraId);
    }
}
