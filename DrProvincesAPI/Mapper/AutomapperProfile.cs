using AutoMapper;
using DrProvincesAPI.Models;
using DrProvincesAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrProvincesAPI.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Province, ProvinceDto>().ReverseMap();
        }
    }
}
