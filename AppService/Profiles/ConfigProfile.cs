using Application.AppService.IConfig.Dto.Config_file_first_kind;
using Application.AppService.IConfig.Dto.Config_file_second_kind;
using Application.AppService.IConfig.Dto.Config_file_third_kind;
using Application.AppService.IConfig.Dto.Config_major;
using Application.AppService.IConfig.Dto.Config_major_kind;
using Application.AppService.IConfig.Dto.Config_public_char;
using AutoMapper;
using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class ConfigProfile : Profile
    {
        public ConfigProfile()
        {
            //I级机构
            CreateMap<Config_file_first_kindAddDto, Config_file_first_kind>().ReverseMap();
            CreateMap<Config_file_first_kindUpdateDto, Config_file_first_kind>().ReverseMap();

            //II级机构
            CreateMap<Config_file_second_kindAddDto, Config_file_second_kind>().ReverseMap();
            CreateMap<Config_file_second_kindUpdateDto, Config_file_second_kind>().ReverseMap();

            //III级机构
            CreateMap<Config_file_third_kindAddDto, Config_file_second_kind>().ReverseMap();
            CreateMap<Config_file_third_kindUpdateDto, Config_file_second_kind>().ReverseMap();

            //职位分类
            CreateMap<Config_major_kindAddDto, Config_major_kind>().ReverseMap();
            CreateMap<Config_major_kindUpdateDto, Config_major_kind>().ReverseMap();

            //职位
            CreateMap<Config_majorAddDto, Config_major>().ReverseMap();
            CreateMap<Config_majorUpdateDto, Config_major>().ReverseMap();

            //公共属性
            CreateMap<Config_public_charAddDto, Config_public_char>().ReverseMap();
            CreateMap<Config_public_charUpdateDto, Config_public_char>().ReverseMap();

        }
    }
}
