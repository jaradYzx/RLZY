using Domain.Entity.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig
{
    /// <summary>
    /// 公共属性
    /// </summary>
    public interface IConfig_public_charAppService
    {
        // 查询所有
        List<Config_public_char> SeleteAllCPCAsync();


        // 查询(泛)
        List<Config_public_char> SeleteZCSZAsync(string xx);


        // 添加
        Task<int> AddCPCAsync(Config_public_char cpc);

        // 修改
        Task<int> UpdCPCAsync(Config_public_char cpc);

        // 删除
        Task<int> DelCPCAsync(int Id);
    }
}
