using Domain.Entity.Engage;
using Domain.Repository.IEngage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.Engage
{
    public class Engage_resumeRepository : IEngage_resumeRepository
    {
        private readonly MyDbContext myc;

        public Engage_resumeRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddERAsync(Engage_resume er)
        {
            myc.engage_Resumes.Add(er);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelERAsync(Engage_resume er)
        {
            myc.engage_Resumes.Remove(er);
            return await myc.SaveChangesAsync();
        }

        public List<Engage_resume> SeleteAllER()
        {
            return myc.engage_Resumes.ToList();
        }

        public Engage_resume SeleteERById(int id)
        {
            return myc.engage_Resumes.Where(e => e.Res_id == id).FirstOrDefault();
        }

        public async Task<int> UpdERAsync(Engage_resume er)
        {
            myc.engage_Resumes.Update(er);
            return await myc.SaveChangesAsync();
        }
    }
}
