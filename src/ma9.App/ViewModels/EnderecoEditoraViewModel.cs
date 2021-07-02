using System;

namespace ma9.App.ViewModels
{
    public class EnderecoEditoraViewModel : EnderecoViewModel
    {
        public Guid EditoraId { get; set; }
        public EditoraViewModel Editora { get; set; }
    }
}
