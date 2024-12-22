namespace OnlineCourse.Busines
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(UserRegistorDto userRegistorDto);
        Task<bool> LoginAsync(UserLoginDto loginDto);
        Task<bool> LogoutUserAsync();
        Task<bool> CreateRoleAsync(UseRoleDto useRoleDto);
        Task<bool> AssingRoleAsync(AssingRoleDto assingRoleDto);
    }
}
