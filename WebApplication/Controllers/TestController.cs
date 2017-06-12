using Microsoft.AspNetCore.Mvc;
using WebApplication.Core.Services.DataProvider.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private IUserService _userService;

        public TestController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            return Json(_userService.GetUsersAsync(10, 0)); 
        }
    }
}
