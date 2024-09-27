using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_file_second_kind;
using AutoMapper;
using Domain.Entity.Config;
using Domain.Repository.IConfig;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CFSKController : Controller
    {
        private readonly IConfig_file_second_kindAppService cFSK;
        private readonly IMapper mapper;

		public CFSKController(IConfig_file_second_kindAppService cFSK,IMapper mapper)
        {
            this.cFSK = cFSK;
            this.mapper = mapper;
		}
            public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddCFSK(Config_file_second_kindAddDto cfskAddDto)
        {
            Config_file_second_kind cfsk = mapper.Map<Config_file_second_kind>(cfskAddDto);
            int i = await cFSK.AddCFSKAsync(cfsk);
            return Json(i);
        }

        public async Task<IActionResult> UpdateCFSK(Config_file_second_kindAddDto cfskUpDto)
        {
            Config_file_second_kind cfsk = mapper.Map<Config_file_second_kind>(cfskUpDto);
            int i = await cFSK.UpdCFSKAsync(cfsk);
            return Json(i);
        }

        public async Task<IActionResult> GetCFSK()
        {
            List<Config_file_first_kind> cffks = await cFSK.GetCFFKAsync();
            return Json(cffks);

        }

        public async Task<IActionResult> SelectAllCFSK()
        {
            List<Config_file_second_kind> cfsks = await cFSK.SelectAllCFSK();
            return Json(cfsks);

        }

        public async Task<IActionResult> SelectCFSKBySKName(string x)
        {
            List<Config_file_second_kind> cfsks = await cFSK.SelectCFSKBySKName(x);
            return Json(cfsks);

        }


        [HttpGet("GetCFSKById/{ffid}")]
        public async Task<IActionResult> GetCFSKById(string ffid)
        {
            List<Config_file_first_kind> cffks = await cFSK.GetCFFKAsyncById(ffid);
            return Json(cffks);
        }

        public async Task<IActionResult> DeleteCFSK(int id)
        {
            int i = await cFSK.DelCFSKAsync(id);
            return Json(i);
        }


    }
}
