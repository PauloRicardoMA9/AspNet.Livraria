using System;

namespace ma9.App.ViewModels
{
    public class EnderecoClienteViewModel : EnderecoViewModel
    {
        public Guid ClienteId { get; set; }
        public ClienteViewModel Cliente { get; set; }
    }
}
