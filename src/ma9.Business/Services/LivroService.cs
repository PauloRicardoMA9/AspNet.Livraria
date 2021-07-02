using ma9.Business.Interfaces.Services;
using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task Adicionar(Livro livro)
        {
            await _livroRepository.Adicionar(livro);
        }

        public async Task Atualizar(Livro livro)
        {
            await _livroRepository.Atualizar(livro);
        }

        public async Task Remover(Guid id)
        {
            await _livroRepository.Remover(id);
        }

        public void Dispose()
        {
            _livroRepository?.Dispose();
        }
    }
}
