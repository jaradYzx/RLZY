using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig
{
    /// <summary>
    /// I级机构设置
    /// </summary>
    public interface IConfig_file_first_kindAppService
    {
        //查询
        Task<List<Config_file_first_kind>> SelectAllCFFK();

        //添加
        Task<int> AddCFFKAsync(Config_file_first_kind cffk);

        // 修改
        Task<int> UpdCFFKAsync(Config_file_first_kind cffk);

        // 删除
        Task<int> DelCFFKAsync(int Id);
    }
}
