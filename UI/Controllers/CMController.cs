using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_major;
using Application.AppService.IConfig.Dto.Config_major_kind;
using AutoMapper;
using Domain.Entity.Config;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CMController : Controller
    {
        private readonly IConfig_majorAppService cM;
        private readonly IMapper mapper;

        public CMController(IConfig_majorAppService cM, IMapper mapper)
        {
            this.cM = cM;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> SelectAllCM()
        {
            List<Config_major> cms = cM.SelectAllCM();
            return Json(cms);

        }

        public async Task<IActionResult> AddCMK(Config_majorAddDto cmAddDto)
        {
            Config_major cm = mapper.Map<Config_major>(cmAddDto);
            int i = await cM.AddCMAsync(cm);
            return Json(i);
        }

        public async Task<IActionResult> DelCM(int id)
        {
            int i = await cM.DelCMAsync(id);
            return Json(i);
        }

        public async Task<IActionResult> SeleteZWMC(string x)
        {
            List<Config_major> cms = cM.SeleteZWMCsync(x);
            return Json(cms);

        }

    }
}
