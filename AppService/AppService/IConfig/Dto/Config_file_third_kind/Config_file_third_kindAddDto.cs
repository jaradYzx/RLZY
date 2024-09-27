using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig.Dto.Config_file_third_kind
{
    public class Config_file_third_kindAddDto
    {
        public int Ftk_id { get; set; }//主键，自动增长列     
        public string? First_kind_id { get; set; }//一级机构编号

        public string? First_kind_name { get; set; }// 一级机构名称 
        public string? Second_kind_id { get; set; }//二级机构编号 
        public string? Second_kind_name { get; set; }// 二级机构名称   
        public string? Third_kind_id { get; set; }//三级机构编号     
        public string? Third_kind_name { get; set; }// 三级机构名称   
        public string? Third_kind_sale_id { get; set; }//三级机构销售责任人编号 

        public string? Third_kind_is_retail { get; set; }//三级机构是否为零售店 
    }
}
