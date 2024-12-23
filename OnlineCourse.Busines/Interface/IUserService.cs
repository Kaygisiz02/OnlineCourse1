using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Busines
{
    public interface IUserService
    {
       Task<IdentityResult>AddUserAsync(UserRegisterDto userRegisterDto);
        Task<bool> LoginAsync(UserLoginDto userLoginDto); 
        Task<bool> LogoutAsync();
        Task<bool> AddRoleAsync(UserRoleDto userRoleDto );
        Task<bool> AssingRoleAsync(AssingRoleDto assingRoleDto);
    }
}
