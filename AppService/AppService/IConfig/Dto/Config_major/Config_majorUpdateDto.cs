using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig.Dto.Config_major
{
    public class Config_majorUpdateDto
    {
        public int Mak_id { get; set; }//主键，自动增长列 
        public char? Major_kind_id { get; set; }//职位分类编号  
        public string? Major_kind_name { get; set; }//职位分类名称  
        public char? Major_id { get; set; }//职位编号  
        public string? Major_name { get; set; }//职位名称    
        public int? Test_amount { get; set; }//题套数量   
    }
}
