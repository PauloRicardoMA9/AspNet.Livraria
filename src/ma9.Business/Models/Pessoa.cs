namespace ma9.Business.Models
{
    public abstract class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
    }
}
