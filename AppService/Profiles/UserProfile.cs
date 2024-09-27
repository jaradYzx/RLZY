using Application.AppService.User.Dto;
using AutoMapper;
using Domain.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, Users>().ReverseMap();
        }
    }
}
