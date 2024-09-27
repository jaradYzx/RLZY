using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppService.IEngage.Dto.Engage_resume
{
    public class Engage_resumeUpdDto
    {
        public int Res_id { get; set; }     //主键
        public string? Human_name { get; set; } //姓名
        public string? Engage_type { get; set; }    //招聘类型
        public string? Human_address { get; set; } //地址
        public string? Human_postcode { get; set; } //邮政编码
        public string? Human_major_kind_id { get; set; }    //职位分类编号
        public string? Human_major_kind_name { get; set; }   //职位分类名称
        public string? Human_major_id { get; set; }     //职位编号
        public string? Human_major_name { get; set; }    //职位名称
        public string? Human_telephone { get; set; }     //电话号码
        public string? Human_homephone { get; set; }     //家庭电话
        public string? Human_mobilephone { get; set; }      //手机
        public string? Human_email { get; set; }    //Email
        public string? Human_hobby { get; set; }    //兴趣爱好
        public string? Human_specility { get; set; }    //特长
        public string? Human_sex { get; set; }      //性别
        public string? Human_religion { get; set; }     //宗教信仰
        public string? Human_party { get; set; }    //政治面貌
        public string? Human_nationality { get; set; }      //国籍
        public string? Human_race { get; set; }     //民族
        public DateTime? Human_birthday { get; set; }     //生日
        public int? Human_age { get; set; }      //年龄
        public string? Human_educated_degree { get; set; }      //教育程度
        public int? Human_educated_years { get; set; }       //教育年限
        public string? Human_educated_major { get; set; }       //专业
        public string? Human_college { get; set; }      //毕业院校
        public string? Human_idcard { get; set; }       //身份证号
        public string? Human_birthplace { get; set; }       //出生地
        public double? Demand_salary_standard { get; set; }     //薪酬标准
        public string? Human_history_records { get; set; }      //个人履历
        public string? Remark { get; set; }     //备注
        public string? Recomandation { get; set; }      //推荐意见
        public string? Human_picture { get; set; }      //照片
        public string? Attachment_name { get; set; }    //档案附件
        public int? Check_status { get; set; }       //复核状态
        public string? Register { get; set; }       //登记人
        public DateTime? Regist_time { get; set; }    //登记时间
        public string? Checker { get; set; }        //复核人姓名
        public DateTime? Check_time { get; set; }     //复核时间
        public int? Interview_status { get; set; }       //面试状态
        public int? Total_points { get; set; }       //总分
        public int? Test_amount { get; set; }        //考试次数
        public string? Test_checker { get; set; }       //测试复核人
        public DateTime? Test_check_time { get; set; }        //测试复核时间
        public string? Pass_register { get; set; }      //通过登记人姓名
        public DateTime? Pass_regist_time { get; set; }       //通过登记时间
        public string? Pass_checker { get; set; }       //通过复核人姓名
        public DateTime? Pass_check_time { get; set; }        //通过复核时间
        public int? Pass_check_status { get; set; }      //通过的复核状态
        public string? Pass_checkComment { get; set; }      //录用申请审核意见
        public string? Pass_passComment { get; set; }        //录用申请审批意见
    }
}
