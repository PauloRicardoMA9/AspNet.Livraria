using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ma9.App.ViewModels
{
    public class EditoraViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        /* EF Relations */
        public EnderecoEditoraViewModel EnderecoEditora { get; set; }
        public IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
