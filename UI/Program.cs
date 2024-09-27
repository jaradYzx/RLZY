
using Application.AppService.Config;
using Application.AppService.Engage;
using Application.AppService.IConfig;
using Application.AppService.IEngage;
using Application.AppService.IUser;
using Application.AppService.User;
using Application.Profiles;
using Domain.Entity.Config;
using Domain.Repository;
using Domain.Repository.IConfig;
using Domain.Repository.IEngage;
using EFCore;
using EFCore.Repository.Config;
using EFCore.Repository.Engage;
using EFCore.Repository.User;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            {
                builder.Services.AddDbContext<MyDbContext>();

                builder.Services.AddTransient<IUserRepository, UserRepository>();
                builder.Services.AddTransient<IUsersAppService, UsersAppService>();

                builder.Services.AddTransient<IConfig_file_first_kindRepository, Config_file_first_kindRepository>();
                builder.Services.AddTransient<IConfig_file_first_kindAppService, Config_file_first_kindAppService>();

                builder.Services.AddTransient<IConfig_file_second_kindRepository, Config_file_second_kindRepository>();
                builder.Services.AddTransient<IConfig_file_second_kindAppService, Config_file_second_kindAppService>();
                
                builder.Services.AddTransient<IConfig_file_third_kindRepository, Config_file_third_kindRepository>();
                builder.Services.AddTransient<IConfig_file_third_kindAppService, Config_file_third_kindAppService>();

                builder.Services.AddTransient<IConfig_majorRepository, Config_majorRepository>();
                builder.Services.AddTransient<IConfig_majorAppService, Config_majorAppService>();

                builder.Services.AddTransient<IConfig_major_kindRepository, Config_major_kindRepository>();
                builder.Services.AddTransient<IConfig_major_kindAppService, Config_major_kindAppService>();

                builder.Services.AddTransient<IConfig_public_charRepository, Config_public_charRepository>();
                builder.Services.AddTransient<IConfig_public_charAppService, Config_public_charAppService>();

                //

                builder.Services.AddTransient<IEngage_major_releaseRepository, Engage_major_releaseRepository>();
                builder.Services.AddTransient<IEngage_major_releaseAppService, Engage_major_releaseAppService>();

                builder.Services.AddTransient<IEngage_interviewRepository, Engage_interviewRepository>();
                builder.Services.AddTransient<IEngage_interviewAppService, Engage_interviewAppService>();

                builder.Services.AddTransient<IEngage_resumeRepository, Engage_resumeRepository>();
                builder.Services.AddTransient<IEngage_resumeAppService, Engage_resumeAppService>();


                builder.Services.AddAutoMapper(typeof(UserProfile));
                builder.Services.AddAutoMapper(typeof(ConfigProfile));
                builder.Services.AddAutoMapper(typeof(EngageProfile));

            }

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
