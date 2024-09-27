using Application.AppService.IConfig;
using Application.AppService.IConfig.Dto.Config_file_first_kind;
using Application.AppService.IConfig.Dto.Config_file_second_kind;
using Application.AppService.IConfig.Dto.Config_file_third_kind;
using AutoMapper;
using Domain.Entity.Config;
using Domain.Repository.IConfig;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
	public class CFTKController : Controller
	{
        private readonly IConfig_file_third_kindAppService cFTK;
        private readonly IMapper mapper;

        public CFTKController(IConfig_file_third_kindAppService cFTK, IMapper mapper)
        {
            this.cFTK = cFTK;
            this.mapper = mapper;
        }
        public IActionResult Index()
		{
			return View();
		}

        [HttpPut]
        public async Task<IActionResult> AddCFTK(Config_file_third_kind cftkAddDto)
        {
            int i = await cFTK.AddCFTKAsync(cftkAddDto);
            return Json(i);
        }

        public async Task<IActionResult> UpdateCFTK(Config_file_third_kind cftkUpDto)
        {
            int i = await cFTK.UpdCFTKAsync(cftkUpDto);
            return Json(i);
        }

        public async Task<IActionResult> SelectAllCFTK()
        {
            List<Config_file_third_kind> cfsks = cFTK.SelectAllCFTK();
            return Json(cfsks);
        }

        public async Task<IActionResult> SelectCFTKByTKName(string x)
        {
            List<Config_file_third_kind> cftks = await cFTK.SelectCFTKByTKName(x);
            return Json(cftks);

        }

        public async Task<IActionResult> DeleteCFTK(int id)
        {
            int i = await cFTK.DelCFTKAsync(id);
            return Json(i);
        }

    }
}
