using Microsoft.AspNetCore.Identity;
namespace OnlineCourse.Busines
{
    public class UserService(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager, RoleManager<AppRole> _roleManager) : IUserService
    {
        public Task<bool> AddRoleAsync(UserRoleDto userRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> AddUserAsync(UserRegisterDto _userRegisterDto)
        {
            var user = new AppUser
            {
                FirstName = _userRegisterDto.FirstName,
                LastName = _userRegisterDto.LastName,
                UserName = _userRegisterDto.UserName,
                Email = _userRegisterDto.Email,

            };
            if (_userRegisterDto.Password != _userRegisterDto.ConfirmPassword)
            {
                return new IdentityResult();
            }
            return await _userManager.CreateAsync(user, _userRegisterDto.Password);

        }

        public Task<bool> AssingRoleAsync(AssingRoleDto _assingRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(UserLoginDto _userLoginDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
