using ma9.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace ma9.Data.Contexts
{
    public class ModelsDbContext : DbContext
    {
        public ModelsDbContext(DbContextOptions<ModelsDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios{ get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<EnderecoCliente> EnderecosClientes { get; set; }
        public DbSet<EnderecoFuncionario> EnderecosFuncionarios{ get; set; }
        public DbSet<EnderecoEditora> EnderecosEditoras{ get; set; }
    }
}
