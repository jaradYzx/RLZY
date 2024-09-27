using Domain.Entity.Engage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IEngage
{
    /// <summary>
    /// 简历管理
    /// </summary>
    public interface IEngage_resumeAppService
    {

        // 查询
        List<Engage_resume> SeleteAllER();

        // 根据Id查询
        Engage_resume SeleteERById(int id);

        // 添加
        Task<int> AddERAsync(Engage_resume er);

        // 修改
        Task<int> UpdERAsync(Engage_resume er);

        // 删除
        Task<int> DelERAsync(Engage_resume er);
    }
}
