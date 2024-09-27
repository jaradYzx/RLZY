using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig
{
    /// <summary>
    /// II级机构设置
    /// </summary>
    public interface IConfig_file_second_kindAppService
    {

        Task<List<Config_file_first_kind>> GetCFFKAsync();

        //查询
        Task<List<Config_file_second_kind>> SelectAllCFSK();

        //查询二级
        Task<List<Config_file_second_kind>> SelectCFSKBySKName(string SKName);

        // 添加
        Task<int> AddCFSKAsync(Config_file_second_kind cfsk);

        // 修改
        Task<int> UpdCFSKAsync(Config_file_second_kind cfsk);

        // 删除
        Task<int> DelCFSKAsync(int Id);

        Task<List<Config_file_first_kind>> GetCFFKAsyncById(string kid);
    }
}
