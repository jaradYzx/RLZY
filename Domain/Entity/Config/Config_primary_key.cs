using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Config
{
    public class Config_primary_key// 关键字设置，包括人力资源管理，薪酬发放，激励管理，调动管理，薪酬标准，培训     
    {
        public int Prk_id { get; set; }//主键，自动增长列 

        public string Primary_key_table { get; set; }// 关键字所涉及的数据库表名
                                                     // 
        public string Primary_key { get; set; }//关键字 

        public string Key_name { get; set; }//中文关键字 

        public int Primary_key_status { get; set; }//是否为关键字原本类型是bit

    }
}
