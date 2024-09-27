using Domain.Entity.User;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly MyDbContext myc;

        public UserRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<Users> GetUsers(Users users)
        {
            Users uu = myc.Users.Where(e => e.UName == users.UName && e.UPassWord == users.UPassWord).FirstOrDefault();
            return uu;
        }
    }
}
