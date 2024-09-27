using Domain.Entity.Engage;
using Domain.Repository.IEngage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.User;

namespace EFCore.Repository.Engage
{
    public class Engage_interviewRepository : IEngage_interviewRepository
    {
        private readonly MyDbContext myc;

        public Engage_interviewRepository(MyDbContext myc)
        {
            this.myc = myc;
        }
        public async Task<int> AddEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Add(ei);
            return await myc.SaveChangesAsync();
        }

        public async Task<int> DelEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Remove(ei);
            return await myc.SaveChangesAsync();
        }

        /// <summary>
        /// 邮件发送方法
        /// </summary>
        /// <param name="toMial">收件人邮箱</param>
        /// <param name="fromMial">发件人邮箱</param>
        /// <param name="userID">发件人邮箱帐号 如QQ邮箱 为QQ号码 </param>
        /// <param name="userPwd">发件人邮箱受权码</param>
        /// <param name="serverAddress">邮件服务地址 如QQ邮箱服务地址为smtp.qq.com</param>
        /// <param name="subject">邮件主题</param>
        /// <param name="body">邮件内容</param>
        /// <param name="filePath">文件位置</param>
        /// <returns></returns>
        public bool MailSender(string toMial)
        {
            try
            {
                //创建一个邮件对像
                MailMessage mailObject = new MailMessage();
                //设置发件人
                mailObject.From = new MailAddress("2622667854@qq.com");
                //设置收件人
                mailObject.To.Add(new MailAddress(toMial));

                //设置邮件主题
                mailObject.SubjectEncoding = Encoding.UTF8;
                mailObject.Subject = "录用审批结果";

                //设置邮件内容
                mailObject.BodyEncoding = Encoding.UTF8;//编码
                mailObject.Body = "录用通过，您已成功被我司录用，请即日到我司报名！";

                ////发送文件(附件)
                //if (string.IsNullOrEmpty(""))
                //{//附件地址为空时 则不发送
                //    Attachment amen = new Attachment(@"C:\Users\新建文本文档.txt");
                //    mailObject.Attachments.Add(amen);
                //}

                //创建一个发送邮件的对像 
                SmtpClient smtpClient = new SmtpClient();
                //服务地址  如QQ邮箱  smtp.qq.com
                smtpClient.Host = "smtp.qq.com";
                //帐号和受权码
                smtpClient.Credentials = new NetworkCredential("2622667854", "izbvdityltimecge");
                smtpClient.Send(mailObject);
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Engage_interview> SeleteAllEI()
        {
            return myc.engage_Interviews.ToList();
        }

        public async Task<int> UpdEIAsync(Engage_interview ei)
        {
            myc.engage_Interviews.Update(ei);
            return await myc.SaveChangesAsync();
        }
    }
}
