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
    public class Config_major_kindAppService : IConfig_major_kindAppService
    {
        private readonly IConfig_major_kindRepository cmkr;

        public Config_major_kindAppService(IConfig_major_kindRepository cmkr)
        {
            this.cmkr = cmkr;
        }

        public Task<int> AddCMKAsync(Config_major_kind cmk)
        {
            return cmkr.AddCMKAsync(cmk);
        }

        public Task<int> DelCMKAsync(int Id)
        {
            return cmkr.DelCMKAsync(Id);
        }

        public List<Config_major_kind> SelectAllCMK()
        {
            return cmkr.SelectAllCMK();
        }

        public Task<int> UpdCMKAsync(Config_major_kind cmk)
        {
            return cmkr.UpdCMKAsync(cmk);
        }
    }
}
