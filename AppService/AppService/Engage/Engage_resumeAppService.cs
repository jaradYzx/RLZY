using Application.AppService.IEngage;
using Domain.Entity.Engage;
using Domain.Repository.IEngage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.Engage
{
    public class Engage_resumeAppService : IEngage_resumeAppService
    {
        private readonly IEngage_resumeRepository err;

        public Engage_resumeAppService(IEngage_resumeRepository err)
        {
            this.err = err;
        }
        public Task<int> AddERAsync(Engage_resume er)
        {
            return err.AddERAsync(er);
        }

        public Task<int> DelERAsync(Engage_resume er)
        {
            return err.DelERAsync(er);
        }

        public List<Engage_resume> SeleteAllER()
        {
            List<Engage_resume> er = err.SeleteAllER();
            return er;
        }

        public Engage_resume SeleteERById(int id)
        {
            Engage_resume er = err.SeleteERById(id);
            return er;
        }

        public Task<int> UpdERAsync(Engage_resume er)
        {
            return err.UpdERAsync(er);
        }
    }
}
