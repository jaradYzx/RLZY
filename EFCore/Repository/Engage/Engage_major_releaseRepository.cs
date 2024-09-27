using Domain.Entity.Config;
using Domain.Entity.Human_Resources_File;
using Domain.Repository.IEngage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Engage
{
    public class Engage_major_releaseRepository : IEngage_major_releaseRepository
    {
        private readonly MyDbContext myc;

        public Engage_major_releaseRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddEMRAsync(Engage_major_release emr)
        {
            myc.engage_Major_Releases.Add(emr);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelEMRAsync(Engage_major_release emr)
        {
            myc.engage_Major_Releases.Remove(emr);
            return await myc.SaveChangesAsync();
        }

        public List<Engage_major_release> SeleteAllEMR()
        {
            return myc.engage_Major_Releases.ToList();
        }

        public async Task<int> UpdEMRAsync(Engage_major_release emr)
        {
            myc.engage_Major_Releases.Update(emr);
            return await myc.SaveChangesAsync();
        }
    }
}
