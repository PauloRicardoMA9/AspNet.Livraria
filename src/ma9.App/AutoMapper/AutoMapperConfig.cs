using AutoMapper;
using ma9.App.ViewModels;
using ma9.Business.Models;

namespace ma9.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Funcionario, FuncionarioViewModel>().ReverseMap();
            CreateMap<Editora, EditoraViewModel>().ReverseMap();
            CreateMap<Livro, LivroViewModel>().ReverseMap();
            CreateMap<EnderecoCliente, EnderecoClienteViewModel>().ReverseMap();
            CreateMap<EnderecoFuncionario, EnderecoFuncionarioViewModel>().ReverseMap();
            CreateMap<EnderecoEditora, EnderecoEditoraViewModel>().ReverseMap();
        }
    }
}
