using Application.AppService.IConfig.Dto.Config_public_char;
using Application.AppService.IEngage.Dto.Engage_interview;
using Application.AppService.IEngage.Dto.Engage_major_release;
using Application.AppService.IEngage.Dto.Engage_resume;
using AutoMapper;
using Domain.Entity.Config;
using Domain.Entity.Engage;
using Domain.Entity.Human_Resources_File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    public class EngageProfile : Profile
    {
        public EngageProfile()
        {

            //面试表
            CreateMap<Engage_interviewAddDto, Engage_interview>();
            CreateMap<Engage_interviewDeleteDto, Engage_interview>();
            CreateMap<Engage_interviewUpdateDto, Engage_interview>();

            //职位发表登记表
            CreateMap<Engage_major_releaseAddDto, Engage_major_release>();
            CreateMap<Engage_major_releaseDelDto, Engage_major_release>();
            CreateMap<Engage_major_releaseUpdDto, Engage_major_release>();

            //简历管理
            CreateMap<Engage_resumeAddDto, Engage_resume>();
            CreateMap<Engage_resumeDelDto, Engage_resume>();
            CreateMap<Engage_resumeUpdDto, Engage_resume>();
        }
    }
}
