using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IEngage.Dto.Engage_interview
{
    public class Engage_interviewUpdateDto
    {
        public int Ein_id { get; set; }     //主键
        public string Human_name { get; set; }      //姓名
        public int Interview_amount { get; set; }       //面试次数
        public string Human_major_kind_id { get; set; }        //职位分类编号
        public string Human_major_kind_name { get; set; }       //职位分类名称
        public string Human_major_id { get; set; }     //职位编号
        public string Human_major_name { get; set; }        //职位名称
        public string Image_degree { get; set; }       //形象等级
        public string Native_language_degree { get; set; }     //口才等级
        public string Foreign_language_degree { get; set; }        //外语水平等级
        public string Response_speed_degree { get; set; }      //应变能力  
        public string EQ_degree { get; set; }      //EQ等级
        public string IQ_degree { get; set; }      //IQ_等级
        public string Multi_quality_degree { get; set; }       //综合素质
        public string Register { get; set; }        //面试人
        public string Checker { get; set; }     //筛选人
        public DateTime Registe_time { get; set; }      //面试时间
        public DateTime Check_time { get; set; }        //筛选时间
        public string Resume_id { get; set; }      //简历编号
        public string Result { get; set; }      //面试结果
        public string Interview_comment { get; set; }       //面试评价
        public string Check_comment { get; set; }       //筛选评价
        public int Interview_status { get; set; }       //面试状态
        public int Check_status { get; set; }       //筛选状态
    }
}
