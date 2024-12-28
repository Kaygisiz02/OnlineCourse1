namespace OnlineCourse.Presentations.Controllers
{
    public class LoginController(IUserService _userService) : Controller
    {
        public IActionResult Sigin()
        {
            return View();
        }
        [HttpPost]
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
