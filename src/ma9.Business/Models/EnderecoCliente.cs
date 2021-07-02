using System;

namespace ma9.Business.Models
{
    public class EnderecoCliente : Endereco
    {
        /* EF Relations */
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
