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
    public class Config_majorAppService : IConfig_majorAppService
    {
        private readonly IConfig_majorRepository cmr;

        public Config_majorAppService(IConfig_majorRepository cmr)
        {
            this.cmr = cmr;
        }

        public Task<int> AddCMAsync(Config_major cm)
        {
            return cmr.AddCMAsync(cm);
        }

        public Task<int> DelCMAsync(int Id)
        {
            return cmr.DelCMAsync(Id);
        }

        public List<Config_major> SelectAllCM()
        {
            return cmr.SelectAllCM();
        }

        public List<Config_major> SeleteZWMCsync(string xx)
        {
            return cmr.SeleteZWMCsync(xx);
        }

        public Task<int> UpdCMAsync(Config_major cm)
        {
            return cmr.UpdCMAsync(cm);
        }
    }
}
