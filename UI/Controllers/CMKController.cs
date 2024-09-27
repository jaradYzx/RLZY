using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_major_kind;
using Application.AppService.IConfig.Dto.Config_public_char;
using AutoMapper;
using Domain.Entity.Config;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CMKController : Controller
    {
        private readonly IConfig_major_kindAppService cMK;
        private readonly IMapper mapper;

        public CMKController(IConfig_major_kindAppService cMK, IMapper mapper)
        {
            this.cMK = cMK;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> SelectAllCMK()
        {
            List<Config_major_kind> cmks = cMK.SelectAllCMK();
            return Json(cmks);
        }

        public async Task<IActionResult> AddCMK(Config_major_kindAddDto cmkAddDto)
        {
            Config_major_kind cmk = mapper.Map<Config_major_kind>(cmkAddDto);
            int i = await cMK.AddCMKAsync(cmk);
            return Json(i);
        }

        public async Task<IActionResult> DelCMK(int id)
        {
            int i = await cMK.DelCMKAsync(id);
            return Json(i);
        }


    }
}
