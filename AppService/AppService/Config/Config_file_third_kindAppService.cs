using Application.AppService.IConfig;
using Domain.Entity.Config;
using Domain.Repository.IConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.AppService.Config
{
    public class Config_file_third_kindAppService : IConfig_file_third_kindAppService
    {
        private readonly IConfig_file_third_kindRepository cftkr;

        public Config_file_third_kindAppService(IConfig_file_third_kindRepository cftkr)
        {
            this.cftkr = cftkr;
        }
        public Task<int> AddCFTKAsync(Config_file_third_kind cftk)
        {
            return cftkr.AddCFTKAsync(cftk);
        }

        public Task<int> DelCFTKAsync(int Id)
        {
            return cftkr.DelCFTKAsync(Id);
        }

        public List<Config_file_third_kind> SelectAllCFTK()
        {
            List<Config_file_third_kind> cftk = cftkr.SelectAllCFTK();
            return cftk;
        }

        public async Task<List<Config_file_third_kind>> SelectCFTKByTKName(string TKName)
        {
            List<Config_file_third_kind> cftks = await cftkr.SelectCFTKByTKName(TKName);
            return cftks;
        }

        public Task<int> UpdCFTKAsync(Config_file_third_kind cftk)
        {
            return cftkr.UpdCFTKAsync(cftk);
        }
    }
}
