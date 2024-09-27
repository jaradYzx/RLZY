using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Config
{
    public class Config_file_first_kind//一级机构设置    
    {
        [Key]
        public int Ffk_id { get; set; }//主键，自动增长列 

        public string? First_kind_id { get; set; }//一级机构编号 

        public string? First_kind_name { get; set; }// 一级机构名称

        public string? First_kind_salary_id { get; set; }// 一级机构薪酬发放责任人编号 

        public string? First_kind_sale_id { get; set; }//一级机构销售责任人编号 
    }
}
