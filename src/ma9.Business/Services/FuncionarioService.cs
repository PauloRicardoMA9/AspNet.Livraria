using ma9.Business.Interfaces.Repository;
using ma9.Business.Interfaces.Services;
using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IEnderecoFuncionarioRepository _enderecoFuncionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository,
                                  IEnderecoFuncionarioRepository enderecoFuncionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _enderecoFuncionarioRepository = enderecoFuncionarioRepository;
        }

        public async Task Adicionar(Funcionario funcionario)
        {
            await _funcionarioRepository.Adicionar(funcionario);
        }

        public async Task Atualizar(Funcionario funcionario)
        {
            await _funcionarioRepository.Atualizar(funcionario);
        }

        public async Task AtualizarEndereco(EnderecoFuncionario enderecoFuncionario)
        {
            await _enderecoFuncionarioRepository.Atualizar(enderecoFuncionario);
        }

        public async Task Remover(Guid id)
        {
            await _funcionarioRepository.Remover(id);
        }

        public void Dispose()
        {
            _funcionarioRepository?.Dispose();
            _enderecoFuncionarioRepository?.Dispose();
        }
    }
}
