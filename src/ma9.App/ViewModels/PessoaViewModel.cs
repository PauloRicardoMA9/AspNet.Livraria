﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ma9.App.ViewModels
{
    public abstract class PessoaViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
    }
}
