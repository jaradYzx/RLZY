using Application.AppService.IConfig;
using Domain.Entity.Config;
using Domain.Repository.IConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.Config
{
    public class Config_file_second_kindAppService : IConfig_file_second_kindAppService
    {
        private readonly IConfig_file_second_kindRepository cfskr;

        public Config_file_second_kindAppService(IConfig_file_second_kindRepository cfskr)
        {
            this.cfskr = cfskr;
        }

        public Task<int> AddCFSKAsync(Config_file_second_kind cfsk)
        {
            return cfskr.AddCFSKAsync(cfsk);
        }

        public Task<int> DelCFSKAsync(int Id)
        {
            return cfskr.DelCFSKAsync(Id);
        }

        public Task<List<Config_file_first_kind>> GetCFFKAsync()
        {
            return cfskr.GetCFFKAsync();
        }

        public Task<List<Config_file_first_kind>> GetCFFKAsyncById(string kid)
        {
            return cfskr.GetCFFKAsyncById(kid);
        }

        public async Task<List<Config_file_second_kind>> SelectAllCFSK()
        {
            List<Config_file_second_kind> cfsks = await cfskr.SelectAllCFSK();
            return cfsks;
        }

        public async Task<List<Config_file_second_kind>> SelectCFSKBySKName(string SKName)
        {
            List<Config_file_second_kind> cfsks = await cfskr.SelectCFSKBySKName(SKName);
            return cfsks;
        }

        public Task<int> UpdCFSKAsync(Config_file_second_kind cfsk)
        {
            return cfskr.UpdCFSKAsync(cfsk);
        }
    }
}
