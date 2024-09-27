using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.IConfig
{
    /// <summary>
    ///  职位分类设置  
    /// </summary>
    public interface IConfig_major_kindRepository
    {
        //查询
        List<Config_major_kind> SelectAllCMK();

        // 添加
        Task<int> AddCMKAsync(Config_major_kind cmk);

        // 修改
        Task<int> UpdCMKAsync(Config_major_kind cmk);

        // 删除
        Task<int> DelCMKAsync(int Id);

    }
}
