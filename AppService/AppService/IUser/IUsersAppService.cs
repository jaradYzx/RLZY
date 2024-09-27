using Domain.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IUser
{
    /// <summary>
    /// 用户表
    /// </summary>
    public interface IUsersAppService
    {
        //登录
        Task<Users> GetUsers(Users users);
    }
}
