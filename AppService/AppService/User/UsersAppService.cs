using Application.AppService.IUser;
using Domain.Entity.User;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.User
{
    public class UsersAppService : IUsersAppService
    {
        private readonly IUserRepository ur;

        public UsersAppService(IUserRepository ur)
        {
            this.ur = ur;
        }
        public Task<Users> GetUsers(Users users)
        {
            return ur.GetUsers(users);
        }
    }
}
