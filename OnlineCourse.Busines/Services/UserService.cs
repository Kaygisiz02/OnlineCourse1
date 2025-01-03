﻿namespace OnlineCourse.Busines
{
    public class UserService(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager, RoleManager<AppRole> _roleManager) : IUserService
    {
        public Task<bool> AddRoleAsync(UserRoleDto userRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> AddUserAsync(UserRegisterDto userRegisterDto)
        {
            var user = new AppUser
            {
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                UserName = userRegisterDto.UserName,
                Email = userRegisterDto.Email,

            };
            if (userRegisterDto.Password != userRegisterDto.ConfirmPassword)
            {
                return new IdentityResult();
            }
            return await _userManager.CreateAsync(user, userRegisterDto.Password);

        }

        public Task<bool> AssignRoleAsync(List<AssignRoleDto> assingRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppUser>> GetAllUserAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
           return await _userManager.Users.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<string> LoginAsync(UserLoginDto _userLoginDto)
        {
            var user=await _userManager.FindByEmailAsync(_userLoginDto.Email);
            if(user == null)
            {
                return null;
            }
            var result = await _signInManager.PasswordSignInAsync(user, _userLoginDto.Password,false,false);
            if (result.Succeeded)
            {
                return null;
            }
            else
            {
                var IsAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                if (IsAdmin)
                {
                    return "Admin";
                }
                var IsTeacher = await _userManager.IsInRoleAsync(user, "Teacher");
                if (IsTeacher)
                {
                    return "Teacher";
                }
                var IsStudent = await _userManager.IsInRoleAsync(user, "Student");
                if (IsStudent)
                {
                    return null;
                }
            }
            return "succeeded";
        }

        public Task<bool> LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
