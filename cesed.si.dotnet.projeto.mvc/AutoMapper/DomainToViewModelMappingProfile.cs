using AutoMapper;
using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.mvc.ViewsModels;


namespace cesed.si.dotnet.projeto.mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<AtividadeViewModel, Atividade>();
        }
    }
}