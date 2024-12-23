using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Presentations.Controllers
{
    public class RegisterController(IUserService _userService) : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(UserRegisterDto userRegisterDto )
        {
            var result=await _userService.AddUserAsync(userRegisterDto);
            if (!result.Succeeded||!ModelState.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.Code, item.Description);
                }
                return View();
            }
            return RedirectToAction("Index","Login");
            
        }
    }
}
