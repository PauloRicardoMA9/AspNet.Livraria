using System;
using System.ComponentModel.DataAnnotations;

namespace ma9.App.ViewModels
{
    public abstract class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
    }
}
