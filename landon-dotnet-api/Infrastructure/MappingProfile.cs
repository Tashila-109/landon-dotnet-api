using AutoMapper;
using landon_dotnet_api.Models;

namespace landon_dotnet_api.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate / 100.0m));
        }
    }
}