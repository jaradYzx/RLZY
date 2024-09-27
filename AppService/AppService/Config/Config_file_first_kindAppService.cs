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
    public class Config_file_first_kindAppService : IConfig_file_first_kindAppService
    {
        private readonly IConfig_file_first_kindRepository cffkr;

        public Config_file_first_kindAppService(IConfig_file_first_kindRepository cffkr)
        {
            this.cffkr = cffkr;
        }
        public Task<int> AddCFFKAsync(Config_file_first_kind cffk)
        {
            return cffkr.AddCFFKAsync(cffk);
        }

        public Task<int> DelCFFKAsync(int Id)
        {
            return cffkr.DelCFFKAsync(Id);
        }

        public async Task<List<Config_file_first_kind>> SelectAllCFFK()
        {
            List<Config_file_first_kind> cffk = await cffkr.SelectAllCFFK();
            return cffk;
        }

        public Task<int> UpdCFFKAsync(Config_file_first_kind cffk)
        {
            return cffkr.UpdCFFKAsync(cffk);
        }
    }
}
