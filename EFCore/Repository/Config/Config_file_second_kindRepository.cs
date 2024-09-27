using Domain.Entity.Config;
using Domain.Repository.IConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Config
{
    public class Config_file_second_kindRepository : IConfig_file_second_kindRepository
    {
        private readonly MyDbContext myc;

        public Config_file_second_kindRepository(MyDbContext myc)
        {
            this.myc = myc;
        }

        public async Task<int> AddCFSKAsync(Config_file_second_kind cfsk)
        {
            myc.config_file_second_kind.Add(cfsk);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCFSKAsync(int Id)
        {
            Config_file_second_kind cfsk = new Config_file_second_kind()
            {
                Fsk_id = Id
            };
            myc.config_file_second_kind.Remove(cfsk);
            return await myc.SaveChangesAsync();
        }

        public async Task<List<Config_file_first_kind>> GetCFFKAsync()
        {
            return await myc.config_file_first_kind.ToListAsync();
        }

        public async Task<List<Config_file_first_kind>> GetCFFKAsyncById(string kid)
        {
            return await myc.config_file_first_kind.Where(e => e.First_kind_id == kid).ToListAsync();
        }

        public async Task<List<Config_file_second_kind>> SelectAllCFSK()
        {
            return await myc.config_file_second_kind.ToListAsync();
        }

        public async Task<List<Config_file_second_kind>> SelectCFSKBySKName(string SKName)
        {
            return await myc.config_file_second_kind.Where(e => e.First_kind_name == SKName).ToListAsync();
        }

        public async Task<int> UpdCFSKAsync(Config_file_second_kind cfsk)
        {
            myc.config_file_second_kind.Update(cfsk);
            return await myc.SaveChangesAsync();
        }
    }
}
