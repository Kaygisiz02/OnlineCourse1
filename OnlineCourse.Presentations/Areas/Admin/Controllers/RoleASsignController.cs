//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using OnlineCourse.Busines;

//namespace OnlineCourse.Presentations.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    [Route("[area]/[controller]/[action]/{id?}")]
//    public class RoleAssignController(IUserService _userService, UserManager<AppUser> _userManager, RoleManager<AppRole> _roleManager) : Controller
//    {
//        public async Task<IActionResult> Index()
//        {
//            var values = await _userService.GetAllUserAsync();
//            return View(values);
//        }
//        [HttpGet]
//        public async Task<IActionResult> AssignRole(int id)
//        {
//            var user = await _userService.GetUserByIdAsync(id);
//            TempData["userId"] = user.Id;
//            var roles = await _roleManager.Roles.ToListAsync();
//            var userRoles = await _userManager.GetRolesAsync(user);
//            List<AssignRoleDto> assingRoleList = new List<AssignRoleDto>();
//            foreach (var role in roles)
//            {
//                AssignRoleDto assingRoleDto = new AssignRoleDto();
//                assingRoleDto.RoleId = role.Id;
//                assingRoleDto.RoleName = role.Name;
//                assingRoleDto.RoleExist = userRoles.Contains(role.Name);
//                assingRoleList.Add(assingRoleDto);
//            }
//            return View(assingRoleList);
//        }
//        [HttpPost]
//        public async Task<IActionResult> AssingRole(List<AssignRoleDto> assingRoleList)
//        {
//            int userId = (int)TempData["userId"];
//            var user = await _userService.GetUserByIdAsync(userId);
//            foreach (var item in assingRoleList)
//            {
//                if (item.RoleExist)
//                {
//                    await _userManager.AddToRoleAsync(user,item.RoleName);
//                }
//                else
//                {
//                    await _userManager.RemoveFromRoleAsync(user,item.RoleName);
//                }
//            }
//            return RedirectToAction("Index");
//        }

//    }
//}
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace OnlineCourse.Presentations.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class RoleAssignController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(IUserService userService, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userService.GetAllUserAsync();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("Index");
            }

            TempData["userId"] = user.Id;
            var roles = await _roleManager.Roles.ToListAsync();
            var userRoles = await _userManager.GetRolesAsync(user);

            var assignRoleList = roles.Select(role => new AssignRoleDto
            {
                RoleId = role.Id,
                RoleName = role.Name,
                RoleExist = userRoles.Contains(role.Name)
            }).ToList();

            return View(assignRoleList);
        }

        [HttpPost]
        public async Task<IActionResult> AssignRole(List<AssignRoleDto> assignRoleList)
        {
            if (!TempData.ContainsKey("userId") || !(TempData["userId"] is int userId))
            {
                TempData["Error"] = "Invalid user ID.";
                return RedirectToAction("Index");
            }

            var user = await _userService.GetUserByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("Index");
            }

            foreach (var item in assignRoleList)
            {
                if (item.RoleExist)
                {
                    if (!(await _userManager.IsInRoleAsync(user, item.RoleName)))
                    {
                        await _userManager.AddToRoleAsync(user, item.RoleName);
                    }
                }
                else
                {
                    if (await _userManager.IsInRoleAsync(user, item.RoleName))
                    {
                        await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                    }
                }
            }

            TempData["Success"] = "Roles successfully updated.";
            return RedirectToAction("Index");
        }
    }
}
