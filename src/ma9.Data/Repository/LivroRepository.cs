using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(ModelsDbContext context) : base(context) { }

        public async Task<Livro> ObterLivroEditora(Guid id)
        {
            return await Db.Livros.AsNoTracking()
                .Include(editora => editora.Editora)
                .FirstOrDefaultAsync(livro => livro.Id == id);
        }

        public async Task<IEnumerable<Livro>> ObterLivrosEditoras()
        {
            return await Db.Livros.AsNoTracking()
                .Include(editora => editora.Editora)
                .OrderBy(livro => livro.Titulo)
                .ToListAsync();
        }

        public async Task<IEnumerable<Livro>> ObterLivrosPorEditora(Guid editoraId)
        {
            return await Buscar(livro => livro.EditoraId == editoraId);
        }
    }
}
