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
    public class Config_file_first_kindRepository : IConfig_file_first_kindRepository
    {
        private readonly MyDbContext myc;

        public Config_file_first_kindRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddCFFKAsync(Config_file_first_kind cffk)
        {
            myc.config_file_first_kind.Add(cffk);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCFFKAsync(int Id)
        {
            Config_file_first_kind cffk = new Config_file_first_kind()
            {
                Ffk_id = Id
            };
            myc.config_file_first_kind.Remove(cffk);
            return await myc.SaveChangesAsync();
        }

        public async Task<List<Config_file_first_kind>> SelectAllCFFK()
        {
            return await myc.config_file_first_kind.ToListAsync();
        }

        public async Task<int> UpdCFFKAsync(Config_file_first_kind cffk)
        {
            myc.config_file_first_kind.Update(cffk);
            return await myc.SaveChangesAsync();
        }
    }
}
