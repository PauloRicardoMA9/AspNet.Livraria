using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class EditoraRepository : Repository<Editora>, IEditoraRepository
    {
        public EditoraRepository(ModelsDbContext context) : base(context) { }

        public async Task<Editora> ObterEditoraEndereco(Guid id)
        {
            return await Db.Editoras.AsNoTracking()
                .Include(editora => editora.EnderecoEditora)
                .FirstOrDefaultAsync(editora => editora.Id == id);
        }

        public async Task<Editora> ObterEditoraLivrosEndereco(Guid id)
        {
            return await Db.Editoras.AsNoTracking()
                .Include(editora => editora.EnderecoEditora)
                .Include(editora => editora.Livros)
                .FirstOrDefaultAsync(editora => editora.Id == id);
        }
    }
}
