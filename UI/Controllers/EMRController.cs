using Application.AppService.IConfig.Dto.Config_file_first_kind;
using Application.AppService.IEngage;
using Application.AppService.IEngage.Dto.Engage_major_release;
using AutoMapper;
using Dapper;
using Domain.Entity;
using Domain.Entity.Config;
using Domain.Entity.Engage;
using Domain.Entity.Human_Resources_File;
using EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;

namespace UI.Controllers
{
    public class EMRController : Controller
    {
        private readonly IEngage_major_releaseAppService eMR;
        private readonly IMapper mapper;
        private readonly MyDbContext myb;

        public EMRController(IEngage_major_releaseAppService eMR, IMapper mapper,MyDbContext myb)
        {
            this.eMR = eMR;
            this.mapper = mapper;
            this.myb = myb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FYXG()
        {
            return View();
        }

        public IActionResult CX()
        {
            return View();
        }


        public async Task<IActionResult> AddEMR(Engage_major_release emr)
        {
            int i = await eMR.AddEMRAsync(emr);
            return Json(i);
        }

        public async Task<IActionResult> UpdEMR(Engage_major_releaseUpdDto emrUpDto)
        {
            Engage_major_release emr = mapper.Map<Engage_major_release>(emrUpDto);
            int i = await eMR.UpdEMRAsync(emr);
            return Json(i);
        }

        public async Task<IActionResult> SelectAllEMR()
        {
            List<Engage_major_release> emrs = eMR.SeleteAllEMR();
            return Json(emrs);
        }


        public async Task<IActionResult> DelEMR(int id)
        {
            Engage_major_release emr = new Engage_major_release()
            {
                Mre_id = id,
            };
            int i = await eMR.DelEMRAsync(emr);
            return Json(i);
        }


        [HttpGet]
        public FenYe<Engage_major_release> SelectEMRfy(int cpage, int psize)
        {
            FenYe<Engage_major_release> fenYe = new FenYe<Engage_major_release>();
            using (var connection = myb.Database.GetDbConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("tiaoShu", dbType: DbType.Int32, direction: ParameterDirection.Input, value: psize);//输入参
                parameters.Add("tableName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Engage_major_release");//输入参
                parameters.Add("keyName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Mre_id");//输入参
                parameters.Add("nowYe", dbType: DbType.Int32, direction: ParameterDirection.Input, value: cpage);//输入参
                parameters.Add("rows", dbType: DbType.Int32, direction: ParameterDirection.Output);//输出参

                string sql = "procFenYe";
                List<Engage_major_release> zhi = connection.Query<Engage_major_release>(sql, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                fenYe.data = zhi;
                //总行数
                fenYe.rows = parameters.Get<int>("@rows");
            };
            return fenYe;
        }

        //条件分页查询
        [HttpGet]
        public FenYe<Engage_major_release> SelectEMRtjfy(int cpage, int psize, string where)
        {
            Console.WriteLine(cpage);
            Console.WriteLine(psize);
            Console.WriteLine(where);
            FenYe<Engage_major_release> fenYe = new FenYe<Engage_major_release>();
            using (var connection = myb.Database.GetDbConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("pageSize", dbType: DbType.Int32, direction: ParameterDirection.Input, value: psize);//输入参
                parameters.Add("tabelName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Engage_major_release");//输入参
                parameters.Add("keyName", dbType: DbType.String, direction: ParameterDirection.Input, value: "Mre_id");//输入参
                parameters.Add("currentPage", dbType: DbType.Int32, direction: ParameterDirection.Input, value: cpage);//输入参
                parameters.Add("where", dbType: DbType.String, direction: ParameterDirection.Input, value: where);//输入参
                parameters.Add("rows", dbType: DbType.Int32, direction: ParameterDirection.Output);//输出参

                string sql = "procFenYeTJ";
                List<Engage_major_release> zhi = connection.Query<Engage_major_release>(sql, param: parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                fenYe.data = zhi;
                //总行数
                fenYe.rows = parameters.Get<int>("@rows");
            };
            return fenYe;
        }

    }
}
