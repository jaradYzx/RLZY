using Domain.Entity.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IUserRepository
    {

        Task<Users> GetUsers(Users users);
    }
}
