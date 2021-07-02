namespace ma9.Business.Models
{
    public abstract class Endereco : Entidade
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento{ get; set; }
    }
}
