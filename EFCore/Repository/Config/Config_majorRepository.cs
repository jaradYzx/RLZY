using Domain.Entity.Config;
using Domain.Repository.IConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Config
{
    public class Config_majorRepository : IConfig_majorRepository
    {
        private readonly MyDbContext myc;

        public Config_majorRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddCMAsync(Config_major cm)
        {
            myc.config_major.Add(cm);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCMAsync(int Id)
        {
            Config_major cm = new Config_major()
            {
                Mak_id = Id
            };
            myc.config_major.Remove(cm);
            return await myc.SaveChangesAsync();
        }

        public List<Config_major> SelectAllCM()
        {
            return myc.config_major.ToList();
        }

        public List<Config_major> SeleteZWMCsync(string xx)
        {
            return myc.config_major.Where(e => e.Major_kind_name == xx).ToList();
        }

        public async Task<int> UpdCMAsync(Config_major cm)
        {
            myc.config_major.Update(cm);
            return await myc.SaveChangesAsync();
        }
    }
}
