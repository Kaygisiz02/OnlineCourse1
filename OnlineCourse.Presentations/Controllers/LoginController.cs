using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace OnlineCourse.Presentations.Controllers
{
    public class LoginController(UserService _userService) : Controller
    {
        public IActionResult Sigin()
        {
            return View();
        }
        public async Task<IActionResult> Sigin(UserLoginDto userLoginDto)
        {
            var userRoole = await _userService.LoginAsync(userLoginDto);
           if (userRoole == "Admin")
           {
                return RedirectToAction("Index", "About", new { area = "Admin" });
           }
           if (userRoole == "Teacher")
           {
                return RedirectToAction("Index", "MyCourse", new { area = "Teacher" });
           }
           if (userRoole == "Student")
           {
                return RedirectToAction("Index", "CourseRegister", new { area = "Student" });
           }
           else
           {
                ModelState.AddModelError("", "Email veya Şifre Hatalı.");
                return View();
           }
        }
    }
}
