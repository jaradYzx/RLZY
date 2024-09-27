using Application.AppService.IEngage;
using Application.AppService.IEngage.Dto.Engage_resume;
using AutoMapper;
using Dapper;
using Domain.Entity.Engage;
using Domain.Entity;
using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Application.AppService.IEngage.Dto.Engage_interview;
using Domain.Entity.Human_Resources_File;

namespace UI.Controllers
{
    public class EIController : Controller
    {
        private readonly IEngage_interviewAppService eI;
        private readonly IMapper mapper;
        private readonly MyDbContext myc;

        public EIController(IEngage_interviewAppService eI, IMapper mapper, MyDbContext myc)
        {
            this.eI = eI;
            this.mapper = mapper;
            this.myc = myc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MSCX()
        {
            return View();
        }

        public IActionResult MSSX()
        {
            return View();
        }
        
        public IActionResult MSSXCX()
        {
            return View();
        }
        
        public IActionResult LYSQ()
        {
            return View();
        }
        
        public IActionResult LYSQCX()
        {
            return View();
        }
        
        public IActionResult LYSP()
        {
            return View();
        }
        
        public IActionResult LYSPCX()
        {
            return View();
        }
        
        public IActionResult LYCX()
        {
            return View();
        }
        
        public IActionResult LYZS()
        {
            return View();
        }


        public bool MailSender(string toMial) 
        {
            bool flag = eI.MailSender(toMial);
            return flag;
        }

        public async Task<IActionResult> AddEI(Engage_interviewAddDto eIAddDto)
        {
            Engage_interview ei = mapper.Map<Engage_interview>(eIAddDto);
            int i = await eI.AddEIAsync(ei);
            return Json(i);
        }

        public async Task<IActionResult> UpdEMR(Engage_interviewUpdateDto eiUpDto)
        {
            Engage_interview ei = mapper.Map<Engage_interview>(eiUpDto);
            int i = await eI.UpdEIAsync(ei);
            return Json(i);
        }

        public async Task<IActionResult> SelectAllER()
        {
            List<Engage_interview> eis = eI.SeleteAllEI();
            return Json(eis);
        }


        public async Task<IActionResult> DelER(int id)
        {
            Engage_interview ei = new Engage_interview()
            {
                Ein_id = id,
            };
            int i = await eI.DelEIAsync(ei);
            return Json(i);
        }

        [HttpGet]
        public FenYe<Engage_interview> SelectEIfy(int cpage, int psize)
        {
            FenYe<Engage_interview> fenYe = new FenYe<Engage_interview>();
            using (var connection = myc.Database.GetDbConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("tiaoShu", dbType: DbType.Int32, direction: ParameterDirection.Input, value: psize);//输入参
                parameters.Add("tableName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Engage_interview");//输入参
                parameters.Add("keyName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Ein_id");//输入参
                parameters.Add("nowYe", dbType: DbType.Int32, direction: ParameterDirection.Input, value: cpage);//输入参
                parameters.Add("rows", dbType: DbType.Int32, direction: ParameterDirection.Output);//输出参

                string sql = "procFenYe";
                List<Engage_interview> zhi = connection.Query<Engage_interview>(sql, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                fenYe.data = zhi;
                //总行数
                fenYe.rows = parameters.Get<int>("@rows");
            };
            return fenYe;
        }

        //条件分页查询
        [HttpGet]
        public FenYe<Engage_interview> SelectEItjfy(int cpage, int psize, string where)
        {
            Console.WriteLine(cpage);
            Console.WriteLine(psize);
            Console.WriteLine(where);
            FenYe<Engage_interview> fenYe = new FenYe<Engage_interview>();
            using (var connection = myc.Database.GetDbConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("pageSize", dbType: DbType.Int32, direction: ParameterDirection.Input, value: psize);//输入参
                parameters.Add("tabelName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Engage_interview");//输入参
                parameters.Add("keyName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Ein_id");//输入参
                parameters.Add("currentPage", dbType: DbType.Int32, direction: ParameterDirection.Input, value: cpage);//输入参
                parameters.Add("where", dbType: DbType.String, direction: ParameterDirection.Input, value: where);//输入参
                parameters.Add("rows", dbType: DbType.Int32, direction: ParameterDirection.Output);//输出参

                string sql = "procFenYeTJ";
                List<Engage_interview> zhi = connection.Query<Engage_interview>(sql, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                fenYe.data = zhi;
                //总行数
                fenYe.rows = parameters.Get<int>("@rows");
            };
            return fenYe;
        }
    }
}
