using Domain.Entity.Config;
using Domain.Repository.IConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Config
{
    public class Config_major_kindRepository : IConfig_major_kindRepository
    {
        private readonly MyDbContext myc;

        public Config_major_kindRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddCMKAsync(Config_major_kind cmk)
        {
            myc.config_major_kind.Add(cmk);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCMKAsync(int Id)
        {
            Config_major_kind cmk = new Config_major_kind() 
            {
                Mfk_id=Id
            };
            myc.config_major_kind.Remove(cmk);
            return await myc.SaveChangesAsync();
        }

        public List<Config_major_kind> SelectAllCMK()
        {
            return myc.config_major_kind.ToList();
        }

        public async Task<int> UpdCMKAsync(Config_major_kind cmk)
        {
            myc.config_major_kind.Update(cmk);
            return await myc.SaveChangesAsync();
        }
    }
}
