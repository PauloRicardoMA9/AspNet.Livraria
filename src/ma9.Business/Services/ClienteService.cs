using ma9.Business.Interfaces.Repository;
using ma9.Business.Interfaces.Services;
using ma9.Business.Models;
using System;
using System.Threading.Tasks;

namespace ma9.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEnderecoClienteRepository _enderecoClienteRepository;

        public ClienteService(IClienteRepository clienteRepository,
                              IEnderecoClienteRepository enderecoClienteRepository)
        {
            _clienteRepository = clienteRepository;
            _enderecoClienteRepository = enderecoClienteRepository;
        }

        public async Task Adicionar(Cliente cliente)
        {
            await _clienteRepository.Adicionar(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            await _clienteRepository.Atualizar(cliente);
        }

        public async Task AtualizarEndereco(EnderecoCliente enderecoCliente)
        {
            await _enderecoClienteRepository.Atualizar(enderecoCliente);
        }

        public async Task Remover(Guid id)
        {
            await _clienteRepository.Remover(id);
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
            _enderecoClienteRepository?.Dispose();
        }
    }
}
