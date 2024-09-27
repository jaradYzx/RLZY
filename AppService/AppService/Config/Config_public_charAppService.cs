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
    public class Config_public_charAppService : IConfig_public_charAppService
    {
        private readonly IConfig_public_charRepository cpcr;

        public Config_public_charAppService(IConfig_public_charRepository cpcr)
        {
            this.cpcr = cpcr;
        }
        public Task<int> AddCPCAsync(Config_public_char cpc)
        {
            return cpcr.AddCPCAsync(cpc);
        }

        public Task<int> DelCPCAsync(int Id)
        {
            return cpcr.DelCPCAsync(Id);
        }

        public List<Config_public_char> SeleteAllCPCAsync()
        {
            List<Config_public_char> cpc = cpcr.SeleteAllCPCAsync();
            return cpc;
        }

        public List<Config_public_char> SeleteZCSZAsync(string xx)
        {
            List<Config_public_char> cpc = cpcr.SeleteZCSZAsync(xx);
            return cpc;
        }

        public Task<int> UpdCPCAsync(Config_public_char cpc)
        {
            return cpcr.UpdCPCAsync(cpc);
        }
    }
}
