using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {

        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>();
        }
        
    }
}
