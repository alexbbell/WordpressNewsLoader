using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsLoader.Models
{
    public class NewsformatProfile: Profile
    {
        public NewsformatProfile() 
        {
            CreateMap<MimResponse, MimStoreDto>()
                .ForMember(x=>x.title, opt => opt.MapFrom(src => src.title.rendered))
                .ForMember(x => x.excerpt, opt => opt.MapFrom(src => src.excerpt.rendered));
        }
    }
}
