using Domain.Entity.Config;
using Domain.Repository.IConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EFCore.Repository.Config
{
    public class Config_file_third_kindRepository : IConfig_file_third_kindRepository
    {
        private readonly MyDbContext myc;

        public Config_file_third_kindRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddCFTKAsync(Config_file_third_kind cftk)
        {
            myc.config_file_third_kind.Add(cftk);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCFTKAsync(int Id)
        {
            Config_file_third_kind cftk = new Config_file_third_kind()
            {
                Ftk_id = Id
            };
            myc.config_file_third_kind.Remove(cftk);
            return await myc.SaveChangesAsync();
        }

        public List<Config_file_third_kind> SelectAllCFTK()
        {
            return myc.config_file_third_kind.ToList();
        }

        public async Task<List<Config_file_third_kind>> SelectCFTKByTKName(string TKName)
        {
            return await myc.config_file_third_kind.Where(e => e.Second_kind_name == TKName).ToListAsync();
        }

        public async Task<int> UpdCFTKAsync(Config_file_third_kind cftk)
        {
            myc.config_file_third_kind.Update(cftk);
            return await myc.SaveChangesAsync();
        }
    }
}
