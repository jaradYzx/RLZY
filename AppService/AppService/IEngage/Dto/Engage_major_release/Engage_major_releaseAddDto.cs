using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IEngage.Dto.Engage_major_release
{
    public class Engage_major_releaseAddDto
    {
        public string? First_kind_id { get; set; } //一级机构编号
        public string? First_kind_name { get; set; } //一级机构名称
        public string? Second_kind_id { get; set; } //二级机构编号
        public string? Second_kind_name { get; set; } //二级机构名称
        public string? Third_kind_id { get; set; } //三级机构编号
        public string? Third_kind_name { get; set; } //三级机构名称
        public string? Major_kind_id { get; set; } //职位分类编号
        public string? Major_kind_name { get; set; } //职位分类名称
        public string? Major_id { get; set; }   //职位编号
        public string? Major_name { get; set; }  //职位名称
        public int? Human_amount { get; set; }   //招聘人数
        public string? Engage_type { get; set; }    //招聘类型
        public DateTime? deadline { get; set; }   //截至日期
        public string? Register { get; set; }    //登记人
        public DateTime? RegistTime { get; set; }  //登记时间
        public string? Major_describe { get; set; }     //职位描述
        public string? Engage_required { get; set; }     //招聘要求
        public int? Status { get; set; }     //状态
    }
}
