using System.Collections.Generic;

namespace ma9.Business.Models
{
    public class Editora : Entidade
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        /* EF Relations */
        public EnderecoEditora EnderecoEditora { get; set; }
        public IEnumerable<Livro> Livros { get; set; }
    }
}
