using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    public class RoleASsignController(IUserService _userService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values=await _userService.GetAllUserAsync();
            return View();
        }
        [HttpGet]
        public
    }
}
