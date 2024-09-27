using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_file_first_kind;
using Application.AppService.IConfig.Dto.Config_file_second_kind;
using AutoMapper;
using Domain.Entity.Config;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UI.Controllers
{
    public class CFFKController : Controller
    {
        private readonly IConfig_file_first_kindAppService cFFK;
        private readonly IMapper mapper;

        public CFFKController(IConfig_file_first_kindAppService CFFK,IMapper mapper)
        {
            cFFK = CFFK;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddCFFK(Config_file_first_kindAddDto cffkAddDto)
        {
            Config_file_first_kind cffk = mapper.Map<Config_file_first_kind>(cffkAddDto);
            int i = await cFFK.AddCFFKAsync(cffk);
            return Json(i);
        }

        public async Task<IActionResult> UpdateCFSK(Config_file_first_kindUpdateDto cffkUpDto)
        {
            Config_file_first_kind cffk = mapper.Map<Config_file_first_kind>(cffkUpDto);
            int i = await cFFK.UpdCFFKAsync(cffk);
            return Json(i);
        }


        public async Task<IActionResult> SelectAllCFFK()
        {
            List<Config_file_first_kind> cffks = await cFFK.SelectAllCFFK();
            return Json(cffks);

        }


        public async Task<IActionResult> DeleteCFFK(int id)
        {
            int i = await cFFK.DelCFFKAsync(id);
            return Json(i);
        }

    }
}
