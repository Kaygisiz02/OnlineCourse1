using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class RoleController(RoleManager<AppRole> _roleManager, ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _roleManager.Roles.ToListAsync();
            return View(values);
        }
    }
}
