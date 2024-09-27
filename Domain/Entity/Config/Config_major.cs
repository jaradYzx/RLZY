using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Config
{
    public class Config_major//职位设置   
    {
        public int Mak_id { get; set; }//主键，自动增长列 

        public string? Major_kind_id { get; set; }//职位分类编号  

        public string? Major_kind_name { get; set; }//职位分类名称  

        public string? Major_id { get; set; }//职位编号  

        public string? Major_name { get; set; }//职位名称    

        public int? Test_amount { get; set; }//题套数量   
    }
}
