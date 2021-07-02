using ma9.Business.Interfaces.Repository;
using ma9.Business.Interfaces.Services;
using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Services
{
    public class EditoraService : IEditoraService
    {
        private readonly IEditoraRepository _editoraRepository;
        private readonly IEnderecoEditoraRepository _enderecoEditoraRepository;

        public EditoraService(IEditoraRepository editoraRepository,
                              IEnderecoEditoraRepository enderecoEditoraRepository)
        {
            _editoraRepository = editoraRepository;
            _enderecoEditoraRepository = enderecoEditoraRepository;
        }

        public async Task Adicionar(Editora editora)
        {
            await _editoraRepository.Adicionar(editora);
        }

        public async Task Atualizar(Editora editora)
        {
            await _editoraRepository.Atualizar(editora);
        }

        public async Task AtualizarEndereco(EnderecoEditora enderecoEditora)
        {
            await _enderecoEditoraRepository.Atualizar(enderecoEditora);
        }

        public async Task Remover(Guid id)
        {
            await _editoraRepository.Remover(id);
        }

        public void Dispose()
        {
            _editoraRepository?.Dispose();
            _enderecoEditoraRepository?.Dispose();
        }
    }
}
