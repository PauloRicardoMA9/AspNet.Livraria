using ma9.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ma9.Business.Interfaces.Repository
{
    public interface ILivroRepository : IRepository<Livro>
    {
        Task<IEnumerable<Livro>> ObterLivrosPorEditora(Guid editoraId);
        Task<IEnumerable<Livro>> ObterLivrosEditoras();
        Task<Livro> ObterLivroEditora(Guid id);
    }
}
