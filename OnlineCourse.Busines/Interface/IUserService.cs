namespace OnlineCourse.Busines
{
    public interface IUserService
    {
       Task<IdentityResult>AddUserAsync(UserRegisterDto userRegisterDto);
        Task<string> LoginAsync(UserLoginDto userLoginDto); 
        Task<bool> LogoutAsync();
        Task<bool> AddRoleAsync(UserRoleDto userRoleDto );
        Task<bool> AssignRoleAsync(List<AssignRoleDto> assingRoleDto);
        Task<List<AppUser>> GetAllUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
    }
}
