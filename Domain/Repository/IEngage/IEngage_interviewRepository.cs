using Domain.Entity.Engage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.IEngage
{
    /// <summary>
    /// 面试表
    /// </summary>
    public interface IEngage_interviewRepository
    {
        // 查询
        List<Engage_interview> SeleteAllEI();

        // 添加
        Task<int> AddEIAsync(Engage_interview ei);

        // 修改
        Task<int> UpdEIAsync(Engage_interview ei);

        // 删除
        Task<int> DelEIAsync(Engage_interview ei);

        //发邮件
        bool MailSender(string toMial);
    }
}
