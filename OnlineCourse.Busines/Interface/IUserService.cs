namespace OnlineCourse.Busines
{
    public interface IUserService
    {
       Task<IdentityResult>AddUserAsync(UserRegisterDto userRegisterDto);
        Task<string> LoginAsync(UserLoginDto userLoginDto); 
        Task<bool> LogoutAsync();
        Task<bool> AddRoleAsync(UserRoleDto userRoleDto );
        Task<bool> AssingRoleAsync(List<AssingRoleDto> assingRoleDto);
        Task<List<AppUser>> GetAllUserAsync();
        Task<AppUser> GetserByIdAsync(int id);
    }
}
