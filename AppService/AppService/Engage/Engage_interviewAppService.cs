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
    public class Engage_interviewAppService : IEngage_interviewAppService
    {
        private readonly IEngage_interviewRepository eir;

        public Engage_interviewAppService(IEngage_interviewRepository eir)
        {
            this.eir = eir;
        }
        public Task<int> AddEIAsync(Engage_interview ei)
        {
            return eir.AddEIAsync(ei);
        }

        public Task<int> DelEIAsync(Engage_interview ei)
        {
            return eir.DelEIAsync(ei);
        }

        public bool MailSender(string toMial)
        {
            return eir.MailSender(toMial);
        }

        public List<Engage_interview> SeleteAllEI()
        {
            List<Engage_interview> ei = eir.SeleteAllEI();
            return ei;
        }

        public Task<int> UpdEIAsync(Engage_interview ei)
        {
            return eir.UpdEIAsync(ei);
        }
    }
}
