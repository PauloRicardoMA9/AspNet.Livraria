using System;

namespace ma9.App.ViewModels
{
    public class EnderecoFuncionarioViewModel : EnderecoViewModel
    {
        public Guid FuncionarioId { get; set; }
        public FuncionarioViewModel Funcionario { get; set; }
    }
}
