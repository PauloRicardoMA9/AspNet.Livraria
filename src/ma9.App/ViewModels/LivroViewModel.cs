using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ma9.App.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Edicao { get; set; }

        public string Autor { get; set; }

        /* EF Relations */
        public Guid EditoraId { get; set; }

        public EditoraViewModel Editora { get; set; }

        public IEnumerable<EditoraViewModel> Editoras { get; set; }
    }
}
