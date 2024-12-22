using OnlineCourse.Entity.Entity;
namespace OnlineCourse.Busines
{
    public class UserService(UserManager<AppUser> _userManager,SignInManager<AppUser> _signInManager, RoleManager<AppRole> _roleManager) : IUserService
    {
        public Task<bool> AssingRoleAsync(AssingRoleDto assingRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateRoleAsync(UseRoleDto useRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CreateUserAsync(UserRegistorDto userRegistorDto)
        {
            var user = new AppUser
            {
                FirstName = userRegistorDto.FirstName,
                LastName = userRegistorDto.LastName,
                UserName = userRegistorDto.UserName,
                Email = userRegistorDto.Email,

            };
            if(userRegistorDto.Password !=userRegistorDto.ConfirmPassword)
            {
                return new IdentityResult();
            }

           return await _userManager.CreateAsync(user, userRegistorDto.Password);
        
        }

        public Task<bool> LoginAsync(UserLoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogoutUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
