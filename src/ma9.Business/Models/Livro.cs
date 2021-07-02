using System;

namespace ma9.Business.Models
{
    public class Livro : Entidade
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Edicao { get; set; }
        public string Autor { get; set; }

        /* EF Relations */
        public Guid EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
}
