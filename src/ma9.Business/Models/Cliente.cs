namespace ma9.Business.Models
{
    public class Cliente : Pessoa
    {
        public TipoPessoa TipoPessoa { get; set; }

        /* Ef Relations */
        public EnderecoCliente EnderecoCliente { get; set; }
    }
}
