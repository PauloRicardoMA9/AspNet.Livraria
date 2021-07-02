using System;

namespace ma9.Business.Models
{
    public class EnderecoFuncionario : Endereco
    {
        /* EF Relations */
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
