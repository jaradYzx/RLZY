using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_file_first_kind;
using Application.AppService.IConfig.Dto.Config_public_char;
using AutoMapper;
using Domain.Entity.Config;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CPCController : Controller
    {
        private readonly IConfig_public_charAppService cPc;
        private readonly IMapper mapper;

        public CPCController(IConfig_public_charAppService cPc, IMapper mapper)
        {
            this.cPc = cPc;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ZCSZ()
        {
            return View();
        }

        public IActionResult XZXMSZ()
        {
            return View();
        }

        public async Task<IActionResult> SelectAllCPC()
        {
            List<Config_public_char> cffks = cPc.SeleteAllCPCAsync();
            return Json(cffks);

        }

        public async Task<IActionResult> SeleteZCSZ()
        {
            string xx = "职称";
            List<Config_public_char> cffks =  cPc.SeleteZCSZAsync(xx);
            return Json(cffks);

        }

        public async Task<IActionResult> SeleteXCXMSZ()
        {
            string xx = "薪酬设置";
            List<Config_public_char> cffks = cPc.SeleteZCSZAsync(xx);
            return Json(cffks);

        }

        public async Task<IActionResult> SeleteGGSX(string x)
        {
            List<Config_public_char> cffks = cPc.SeleteZCSZAsync(x);
            return Json(cffks);

        }

        public async Task<IActionResult> AddCPC(Config_public_charAddDto cpcAddDto)
        {
            Config_public_char cpc = mapper.Map<Config_public_char>(cpcAddDto);
            int i = await cPc.AddCPCAsync(cpc);
            return Json(i);
        }

        public async Task<IActionResult> AddXCXM(Config_public_charAddDto cpcAddDto)
        {
            cpcAddDto.Attribute_kind = "薪酬设置";
            Config_public_char cpc = mapper.Map<Config_public_char>(cpcAddDto);
            int i = await cPc.AddCPCAsync(cpc);
            return Json(i);
        }

        public async Task<IActionResult> AddZC(Config_public_charAddDto cpcAddDto)
        {
            cpcAddDto.Attribute_kind = "职称";
            Config_public_char cpc = mapper.Map<Config_public_char>(cpcAddDto);
            int i = await cPc.AddCPCAsync(cpc);
            return Json(i);
        }

        public async Task<IActionResult> DelCPC(int id)
        {
            int i = await cPc.DelCPCAsync(id);
            return Json(i);
        }

    }
}
