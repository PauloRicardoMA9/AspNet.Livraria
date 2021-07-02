using System;

namespace ma9.Business.Models
{
    public class EnderecoEditora : Endereco
    {
        /* EF Relations */
        public Guid EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
}
