using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Config
{
    public class Config_major_kind// 职位分类设置  
    {
        public int Mfk_id { get; set; }//主键，自动增长列  

        public string? Major_kind_id { get; set; }//职位分类编号  

        public string? Major_kind_name { get; set; }//职分类位名称  
    }
}
