using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using System.Linq;

namespace FilmesApi.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(Gerente => Gerente.Cinemas.Select
                (c => new {c.Id, c.Nome, c.Endereco, c.EnderecoFK})));
        }
    }
}
