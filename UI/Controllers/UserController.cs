using Application.AppService.IUser;
using Application.AppService.User.Dto;
using AutoMapper;
using Domain.Entity.User;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersAppService ua;
        private readonly IMapper mapper;

        public UserController( IUsersAppService ua,IMapper mapper) 
        {
            this.ua = ua;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
     

        [HttpPost]
        
        public async Task<IActionResult> GetUser( UserDto ust)
        {
            Users u1=mapper.Map<Users>(ust);
            Users u2=await ua.GetUsers(u1);
            return Json(u2);
        }

    }
}
