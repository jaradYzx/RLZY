using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig
{
    /// <summary>
    /// 职位设置
    /// </summary>
    public interface IConfig_majorAppService
    {

        //查询
        List<Config_major> SelectAllCM();

        // 添加
        Task<int> AddCMAsync(Config_major cm);

        // 修改
        Task<int> UpdCMAsync(Config_major cm);

        // 删除
        Task<int> DelCMAsync(int Id);

        // 查询(泛)
        List<Config_major> SeleteZWMCsync(string xx);
    }
}
