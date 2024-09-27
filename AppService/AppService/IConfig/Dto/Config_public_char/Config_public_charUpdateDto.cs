using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IConfig.Dto.Config_public_char
{
    public class Config_public_charUpdateDto
    {
        public int Pbc_id { get; set; }//主键，自动增长列   
        public string? Attribute_kind { get; set; }//属性的种类   

        public string? Attribute_name { get; set; }//属性的名称   
    }
}
