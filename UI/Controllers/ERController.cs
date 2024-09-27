using Application.AppService.IEngage;
using Application.AppService.IEngage.Dto.Engage_major_release;
using Application.AppService.IEngage.Dto.Engage_resume;
using AutoMapper;
using Dapper;
using Domain.Entity;
using Domain.Entity.Engage;
using Domain.Entity.Human_Resources_File;
using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace UI.Controllers
{
	public class ERController : Controller
	{
        private readonly IEngage_resumeAppService eR;
        private readonly IMapper mapper;
        private readonly MyDbContext myc;

        public ERController(IEngage_resumeAppService eR, IMapper mapper,MyDbContext myc)
        {
            this.eR = eR;
            this.mapper = mapper;
            this.myc = myc;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult JLSX()
		{
			return View();
		}

		public IActionResult YXJLCX()
		{
			return View();
		}
        
		public IActionResult SH()
		{
			return View();
		}



        public async Task<IActionResult> AddER(Engage_resumeAddDto erAddDto)
        {
            Engage_resume er = mapper.Map<Engage_resume>(erAddDto);
            int i = await eR.AddERAsync(er);
            return Json(i);
        }

        public async Task<IActionResult> UpdEMR(Engage_resumeUpdDto erUpDto)
        {
            Engage_resume er = mapper.Map<Engage_resume>(erUpDto);
            int i = await eR.UpdERAsync(er);
            return Json(i);
        }

        public async Task<IActionResult> SelectAllER()
        {
            List<Engage_resume> ers = eR.SeleteAllER();
            return Json(ers);
        }
        
        public async Task<IActionResult> SelectERById(int id)
        {
            Engage_resume er = eR.SeleteERById(id);
            return Json(er);
        }


        public async Task<IActionResult> DelER(int id)
        {
            Engage_resume er = new Engage_resume()
            {
                Res_id = id,
            };
            int i = await eR.DelERAsync(er);
            return Json(i);
        }

        //条件分页查询
        [HttpGet]
        public FenYe<Engage_resume> SelectERtjfy(int cpage, int psize,string where)
        {
            Console.WriteLine(cpage);
            Console.WriteLine(psize);
            Console.WriteLine(where);
            FenYe<Engage_resume> fenYe = new FenYe<Engage_resume>();
            using (var connection = myc.Database.GetDbConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("pageSize", dbType: DbType.Int32, direction: ParameterDirection.Input, value: psize);//输入参
                parameters.Add("tabelName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Engage_resume");//输入参
                parameters.Add("keyName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Res_id");//输入参
                parameters.Add("currentPage", dbType: DbType.Int32, direction: ParameterDirection.Input, value: cpage);//输入参
                parameters.Add("where", dbType: DbType.String, direction: ParameterDirection.Input, value: where);//输入参
                parameters.Add("rows", dbType: DbType.Int32, direction: ParameterDirection.Output);//输出参

                string sql = "procFenYeTJ";
                List<Engage_resume> zhi = connection.Query<Engage_resume>(sql, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                fenYe.data = zhi;
                //总行数
                fenYe.rows = parameters.Get<int>("@rows");
            };
            return fenYe;
        }
    }
}
