using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.IConfig
{
    /// <summary>
    /// 三级机构设置
    /// </summary>
    public interface IConfig_file_third_kindRepository
    {
        //查询
        List<Config_file_third_kind> SelectAllCFTK();


        //查询二级
        Task<List<Config_file_third_kind>> SelectCFTKByTKName(string TKName);

        // 添加
        Task<int> AddCFTKAsync(Config_file_third_kind cftk);

        // 修改
        Task<int> UpdCFTKAsync(Config_file_third_kind cftk);

        // 删除
        Task<int> DelCFTKAsync(int Id);
    }
}
