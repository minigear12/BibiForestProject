using AutoMapper;
using BibiBusiness.DTO;

using BibiBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibiBusiness.Mapper
{
    public class BibiConfig
    {
        public static void createMap(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Bibi, BibiDTO>()
                .ForMember(des => des.OwnerName, act => act.MapFrom(src => src.Owner.OwnerName));

        }
    }
}
