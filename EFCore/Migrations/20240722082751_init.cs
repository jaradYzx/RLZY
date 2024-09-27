using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config_file_first_kind",
                columns: table => new
                {
                    Ffkid = table.Column<int>(name: "Ffk_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstkindid = table.Column<string>(name: "First_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Firstkindname = table.Column<string>(name: "First_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Firstkindsalaryid = table.Column<string>(name: "First_kind_salary_id", type: "text", nullable: true),
                    Firstkindsaleid = table.Column<string>(name: "First_kind_sale_id", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_file_first_kind", x => x.Ffkid);
                });

            migrationBuilder.CreateTable(
                name: "Config_file_second_kind",
                columns: table => new
                {
                    Fskid = table.Column<int>(name: "Fsk_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstkindid = table.Column<string>(name: "First_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Firstkindname = table.Column<string>(name: "First_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Secondkindid = table.Column<string>(name: "Second_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Secondkindname = table.Column<string>(name: "Second_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Secondsalaryid = table.Column<string>(name: "Second_salary_id", type: "text", nullable: true),
                    Secondsaleid = table.Column<string>(name: "Second_sale_id", type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_file_second_kind", x => x.Fskid);
                });

            migrationBuilder.CreateTable(
                name: "Config_file_third_kind",
                columns: table => new
                {
                    Ftkid = table.Column<int>(name: "Ftk_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstkindid = table.Column<string>(name: "First_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Firstkindname = table.Column<string>(name: "First_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Secondkindid = table.Column<string>(name: "Second_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Secondkindname = table.Column<string>(name: "Second_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Thirdkindid = table.Column<string>(name: "Third_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Thirdkindname = table.Column<string>(name: "Third_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Thirdkindsaleid = table.Column<string>(name: "Third_kind_sale_id", type: "text", nullable: true),
                    Thirdkindisretail = table.Column<string>(name: "Third_kind_is_retail", type: "char(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_file_third_kind", x => x.Ftkid);
                });

            migrationBuilder.CreateTable(
                name: "Config_major",
                columns: table => new
                {
                    Makid = table.Column<int>(name: "Mak_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Majorkindid = table.Column<string>(name: "Major_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Majorkindname = table.Column<string>(name: "Major_kind_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Majorid = table.Column<string>(name: "Major_id", type: "char(2)", maxLength: 2, nullable: true),
                    Majorname = table.Column<string>(name: "Major_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Testamount = table.Column<int>(name: "Test_amount", type: "int", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_major", x => x.Makid);
                });

            migrationBuilder.CreateTable(
                name: "Config_major_kind",
                columns: table => new
                {
                    Mfkid = table.Column<int>(name: "Mfk_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Majorkindid = table.Column<string>(name: "Major_kind_id", type: "char(2)", maxLength: 2, nullable: true),
                    Majorkindname = table.Column<string>(name: "Major_kind_name", type: "varchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_major_kind", x => x.Mfkid);
                });

            migrationBuilder.CreateTable(
                name: "Config_primary_key",
                columns: table => new
                {
                    Prkid = table.Column<int>(name: "Prk_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Primarykeytable = table.Column<string>(name: "Primary_key_table", type: "varchar(60)", maxLength: 60, nullable: true),
                    Primarykey = table.Column<string>(name: "Primary_key", type: "varchar(60)", maxLength: 60, nullable: true),
                    Keyname = table.Column<string>(name: "Key_name", type: "varchar(60)", maxLength: 60, nullable: true),
                    Primarykeystatus = table.Column<int>(name: "Primary_key_status", type: "int", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_primary_key", x => x.Prkid);
                });

            migrationBuilder.CreateTable(
                name: "Config_public_char",
                columns: table => new
                {
                    Pbcid = table.Column<int>(name: "Pbc_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attributekind = table.Column<string>(name: "Attribute_kind", type: "varchar(60)", maxLength: 60, nullable: true),
                    Attributename = table.Column<string>(name: "Attribute_name", type: "varchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config_public_char", x => x.Pbcid);
                });

            migrationBuilder.CreateTable(
                name: "Engage_interview",
                columns: table => new
                {
                    Einid = table.Column<int>(name: "Ein_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Humanname = table.Column<string>(name: "Human_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Interviewamount = table.Column<int>(name: "Interview_amount", type: "int", nullable: true),
                    Humanmajorkindid = table.Column<int>(name: "Human_major_kind_id", type: "int", maxLength: 2, nullable: true),
                    Humanmajorkindname = table.Column<string>(name: "Human_major_kind_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Humanmajorid = table.Column<int>(name: "Human_major_id", type: "int", maxLength: 2, nullable: true),
                    Humanmajorname = table.Column<string>(name: "Human_major_name", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Imagedegree = table.Column<string>(name: "Image_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nativelanguagedegree = table.Column<string>(name: "Native_language_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Foreignlanguagedegree = table.Column<string>(name: "Foreign_language_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Responsespeeddegree = table.Column<string>(name: "Response_speed_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EQdegree = table.Column<string>(name: "EQ_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IQdegree = table.Column<string>(name: "IQ_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Multiqualitydegree = table.Column<string>(name: "Multi_quality_degree", type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Register = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Checker = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Registetime = table.Column<DateTime>(name: "Registe_time", type: "datetime2", nullable: true),
                    Checktime = table.Column<DateTime>(name: "Check_time", type: "datetime2", nullable: true),
                    Resumeid = table.Column<int>(name: "Resume_id", type: "int", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Interviewcomment = table.Column<string>(name: "Interview_comment", type: "nvarchar(max)", nullable: true),
                    Checkcomment = table.Column<string>(name: "Check_comment", type: "nvarchar(max)", nullable: true),
                    Interviewstatus = table.Column<int>(name: "Interview_status", type: "int", nullable: true),
                    Checkstatus = table.Column<int>(name: "Check_status", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engage_interview", x => x.Einid);
                });

            migrationBuilder.CreateTable(
                name: "Engage_major_release",
                columns: table => new
                {
                    Mreid = table.Column<int>(name: "Mre_id", type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstkindid = table.Column<string>(name: "First_kind_id", type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Firstkindname = table.Column<string>(name: "First_kind_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Secondkindid = table.Column<string>(name: "Second_kind_id", type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Secondkindname = table.Column<string>(name: "Second_kind_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Thirdkindid = table.Column<string>(name: "Third_kind_id", type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Thirdkindname = table.Column<string>(name: "Third_kind_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Majorkindid = table.Column<string>(name: "Major_kind_id", type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Majorkindname = table.Column<string>(name: "Major_kind_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Majorid = table.Column<string>(name: "Major_id", type: "nvarchar(1)", nullable: true),
                    Majorname = table.Column<string>(name: "Major_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanamount = table.Column<int>(name: "Human_amount", type: "int", nullable: true),
                    Engagetype = table.Column<string>(name: "Engage_type", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Register = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Changer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RegistTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Majordescribe = table.Column<string>(name: "Major_describe", type: "nvarchar(max)", nullable: true),
                    Engagerequired = table.Column<string>(name: "Engage_required", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engage_major_release", x => x.Mreid);
                });

            migrationBuilder.CreateTable(
                name: "Engage_resume",
                columns: table => new
                {
                    Resid = table.Column<int>(name: "Res_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Humanname = table.Column<string>(name: "Human_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Engagetype = table.Column<string>(name: "Engage_type", type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Humanaddress = table.Column<string>(name: "Human_address", type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Humanpostcode = table.Column<string>(name: "Human_postcode", type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Humanmajorkindid = table.Column<int>(name: "Human_major_kind_id", type: "int", maxLength: 2, nullable: true),
                    Humanmajorkindname = table.Column<string>(name: "Human_major_kind_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanmajorid = table.Column<int>(name: "Human_major_id", type: "int", maxLength: 2, nullable: true),
                    Humanmajorname = table.Column<string>(name: "Human_major_name", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humantelephone = table.Column<string>(name: "Human_telephone", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanhomephone = table.Column<string>(name: "Human_homephone", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanmobilephone = table.Column<string>(name: "Human_mobilephone", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanemail = table.Column<string>(name: "Human_email", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Humanhobby = table.Column<int>(name: "Human_hobby", type: "int", maxLength: 200, nullable: true),
                    Humanspecility = table.Column<int>(name: "Human_specility", type: "int", maxLength: 200, nullable: true),
                    Humansex = table.Column<int>(name: "Human_sex", type: "int", maxLength: 2, nullable: true),
                    Humanreligion = table.Column<int>(name: "Human_religion", type: "int", maxLength: 60, nullable: true),
                    Humanparty = table.Column<int>(name: "Human_party", type: "int", maxLength: 60, nullable: true),
                    Humannationality = table.Column<int>(name: "Human_nationality", type: "int", maxLength: 60, nullable: true),
                    Humanrace = table.Column<int>(name: "Human_race", type: "int", maxLength: 60, nullable: true),
                    Humanbirthday = table.Column<int>(name: "Human_birthday", type: "int", nullable: true),
                    Humanage = table.Column<int>(name: "Human_age", type: "int", nullable: true),
                    Humaneducateddegree = table.Column<int>(name: "Human_educated_degree", type: "int", maxLength: 60, nullable: true),
                    Humaneducatedyears = table.Column<int>(name: "Human_educated_years", type: "int", nullable: true),
                    Humaneducatedmajor = table.Column<int>(name: "Human_educated_major", type: "int", maxLength: 60, nullable: true),
                    Humancollege = table.Column<int>(name: "Human_college", type: "int", maxLength: 60, nullable: true),
                    Humanidcard = table.Column<int>(name: "Human_idcard", type: "int", maxLength: 60, nullable: true),
                    Humanbirthplace = table.Column<int>(name: "Human_birthplace", type: "int", maxLength: 200, nullable: true),
                    Demandsalarystandard = table.Column<decimal>(name: "Demand_salary_standard", type: "numeric(15,2)", nullable: true),
                    Humanhistoryrecords = table.Column<int>(name: "Human_history_records", type: "int", nullable: true),
                    Remark = table.Column<int>(type: "int", nullable: true),
                    Recomandation = table.Column<int>(type: "int", nullable: true),
                    Humanpicture = table.Column<int>(name: "Human_picture", type: "int", maxLength: 60, nullable: true),
                    Attachmentname = table.Column<int>(name: "Attachment_name", type: "int", maxLength: 60, nullable: true),
                    Checkstatus = table.Column<int>(name: "Check_status", type: "int", nullable: true),
                    Register = table.Column<int>(type: "int", maxLength: 60, nullable: true),
                    Registtime = table.Column<DateTime>(name: "Regist_time", type: "datetime2", nullable: true),
                    Checker = table.Column<int>(type: "int", maxLength: 60, nullable: true),
                    Checktime = table.Column<int>(name: "Check_time", type: "int", nullable: true),
                    Interviewstatus = table.Column<int>(name: "Interview_status", type: "int", nullable: true),
                    Totalpoints = table.Column<int>(name: "Total_points", type: "int", nullable: true),
                    Testamount = table.Column<int>(name: "Test_amount", type: "int", nullable: true),
                    Testchecker = table.Column<int>(name: "Test_checker", type: "int", maxLength: 60, nullable: true),
                    Testchecktime = table.Column<DateTime>(name: "Test_check_time", type: "datetime2", nullable: true),
                    Passregister = table.Column<int>(name: "Pass_register", type: "int", maxLength: 60, nullable: true),
                    Passregisttime = table.Column<DateTime>(name: "Pass_regist_time", type: "datetime2", nullable: true),
                    Passchecker = table.Column<int>(name: "Pass_checker", type: "int", maxLength: 60, nullable: true),
                    Passchecktime = table.Column<DateTime>(name: "Pass_check_time", type: "datetime2", nullable: true),
                    Passcheckstatus = table.Column<int>(name: "Pass_check_status", type: "int", nullable: true),
                    PasscheckComment = table.Column<string>(name: "Pass_checkComment", type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PasspassComment = table.Column<string>(name: "Pass_passComment", type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engage_resume", x => x.Resid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    UTrueName = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    UPassWord = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
                });

            migrationBuilder.InsertData(
                table: "Config_file_first_kind",
                columns: new[] { "Ffk_id", "First_kind_id", "First_kind_name", "First_kind_salary_id", "First_kind_sale_id" },
                values: new object[] { 1, "01", "集团", "1", "1" });

            migrationBuilder.InsertData(
                table: "Config_file_second_kind",
                columns: new[] { "Fsk_id", "First_kind_id", "First_kind_name", "Second_kind_id", "Second_kind_name", "Second_salary_id", "Second_sale_id" },
                values: new object[] { 1, "01", "集团", "01", "软件公司", "1", "1" });

            migrationBuilder.InsertData(
                table: "Config_file_third_kind",
                columns: new[] { "Ftk_id", "First_kind_id", "First_kind_name", "Second_kind_id", "Second_kind_name", "Third_kind_id", "Third_kind_is_retail", "Third_kind_name", "Third_kind_sale_id" },
                values: new object[] { 1, "01", "集团", "01", "软件公司", "02", "否", "外包组", "1" });

            migrationBuilder.InsertData(
                table: "Config_major",
                columns: new[] { "Mak_id", "Major_id", "Major_kind_id", "Major_kind_name", "Major_name", "Test_amount" },
                values: new object[] { 1, "01", "01", "销售", "人事经理", 0 });

            migrationBuilder.InsertData(
                table: "Config_major_kind",
                columns: new[] { "Mfk_id", "Major_kind_id", "Major_kind_name" },
                values: new object[] { 1, "01", "销售" });

            migrationBuilder.InsertData(
                table: "Config_primary_key",
                columns: new[] { "Prk_id", "Key_name", "Primary_key", "Primary_key_status", "Primary_key_table" },
                values: new object[] { 1, "I级机构名称", "firstKindName", 1, "HumanFile" });

            migrationBuilder.InsertData(
                table: "Config_public_char",
                columns: new[] { "Pbc_id", "Attribute_kind", "Attribute_name" },
                values: new object[] { 1, "国籍", "中国" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Config_file_first_kind");

            migrationBuilder.DropTable(
                name: "Config_file_second_kind");

            migrationBuilder.DropTable(
                name: "Config_file_third_kind");

            migrationBuilder.DropTable(
                name: "Config_major");

            migrationBuilder.DropTable(
                name: "Config_major_kind");

            migrationBuilder.DropTable(
                name: "Config_primary_key");

            migrationBuilder.DropTable(
                name: "Config_public_char");

            migrationBuilder.DropTable(
                name: "Engage_interview");

            migrationBuilder.DropTable(
                name: "Engage_major_release");

            migrationBuilder.DropTable(
                name: "Engage_resume");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
