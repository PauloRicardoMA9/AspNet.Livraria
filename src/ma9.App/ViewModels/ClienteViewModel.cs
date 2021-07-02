namespace ma9.App.ViewModels
{
    public class ClienteViewModel : PessoaViewModel
    {
        public int TipoPessoa { get; set; }
        public EnderecoClienteViewModel EnderecoCliente { get; set; }
    }
}
