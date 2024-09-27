using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.User
{
    public class Users
    {
        [Key]
        public int UId { get; set; }//主键

        public string? UName { get; set; }//用户名

        public string? UTrueName { get; set; }//真实姓名

        public string? UPassWord { get; set; }//密码
    }
}
