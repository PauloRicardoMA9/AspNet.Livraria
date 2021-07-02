using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public class EnderecoEditoraRepository : Repository<EnderecoEditora>, IEnderecoEditoraRepository
    {
        public EnderecoEditoraRepository(ModelsDbContext context) : base(context) { }

        public async Task<EnderecoEditora> ObterEnderecoPorEditora(Guid editoraId)
        {
            return await Db.EnderecosEditoras.AsNoTracking().FirstOrDefaultAsync(editora => editora.Id == editoraId);
        }
    }
}
