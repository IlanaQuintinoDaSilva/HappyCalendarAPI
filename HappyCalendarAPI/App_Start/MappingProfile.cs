using AutoMapper;
using HappyCalendarAPI.DTO;
using HappyCalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyCalendarAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Area, AreaDTO>();
            Mapper.CreateMap<AreaDTO, Area>();
        }
    }
}