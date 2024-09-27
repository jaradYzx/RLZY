using Domain.Entity.Config;
using Domain.Repository.IConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Config
{
    public class Config_public_charRepository : IConfig_public_charRepository
    {
        private readonly MyDbContext myc;

        public Config_public_charRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddCPCAsync(Config_public_char cpc)
        {
            myc.config_public_char.Add(cpc);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelCPCAsync(int Id)
        {
            Config_public_char cpc = new Config_public_char()
            {
                Pbc_id = Id
            };
            myc.config_public_char.Remove(cpc);
            return await myc.SaveChangesAsync();
        }

        public List<Config_public_char> SeleteAllCPCAsync()
        {
            return myc.config_public_char.ToList();
        }

        public List<Config_public_char> SeleteZCSZAsync(string xx)
        {
            return myc.config_public_char.Where(e => e.Attribute_kind == xx).ToList();
        }

        public async Task<int> UpdCPCAsync(Config_public_char cpc)
        {
            myc.config_public_char.Update(cpc);
            return await myc.SaveChangesAsync();
        }
    }
}
