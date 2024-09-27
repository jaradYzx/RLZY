using Application.AppService.IEngage;
using Domain.Entity.Human_Resources_File;
using Domain.Repository.IEngage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.Engage
{
    public class Engage_major_releaseAppService : IEngage_major_releaseAppService
    {
        private readonly IEngage_major_releaseRepository emrr;

        public Engage_major_releaseAppService(IEngage_major_releaseRepository emrr)
        {
            this.emrr = emrr;
        }
        public Task<int> AddEMRAsync(Engage_major_release emr)
        {
            return emrr.AddEMRAsync(emr);
        }

        public Task<int> DelEMRAsync(Engage_major_release emr)
        {
            return emrr.DelEMRAsync(emr);
        }

        public List<Engage_major_release> SeleteAllEMR()
        {
            List<Engage_major_release> emr = emrr.SeleteAllEMR();
            return emr;
        }

        public Task<int> UpdEMRAsync(Engage_major_release emr)
        {
            return emrr.UpdEMRAsync(emr);
        }
    }
}
