using Domain.Entity.Human_Resources_File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IEngage
{
    /// <summary>
    /// 职位发表登记表
    /// </summary>
    public interface IEngage_major_releaseAppService
    {
        // 查询
        List<Engage_major_release> SeleteAllEMR();

        // 添加
        Task<int> AddEMRAsync(Engage_major_release emr);

        // 修改
        Task<int> UpdEMRAsync(Engage_major_release emr);

        // 删除
        Task<int> DelEMRAsync(Engage_major_release emr);
    }
}
