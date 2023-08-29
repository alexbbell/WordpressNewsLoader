using AutoMapper;

namespace NewsLoader.Models
{
    public class NewsformatProfile : Profile
    {
        public NewsformatProfile()
        {
            _ = CreateMap<MimResponse, MimStoreDto>()
                .ForMember(x => x.title, opt => opt.MapFrom(src => src.title.rendered))
                .ForMember(x => x.excerpt, opt => opt.MapFrom(src => src.excerpt.rendered));
        }
    }
}
