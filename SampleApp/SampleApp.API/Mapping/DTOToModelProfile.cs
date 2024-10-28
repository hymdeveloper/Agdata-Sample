using AutoMapper;
using System.Reflection;

namespace SampleApp.API.Mapping
{
    public class DTOToModelProfile : Profile
    {
        public DTOToModelProfile()
        {
            CreateMap<API.DTOs.PersonDto, Domain.DTOs.PersonDto>();
        }
    }
}
