using Microsoft.AspNetCore.Identity;
namespace OnlineCourse.Entity
{
    public class AppRole : IdentityRole<int>
    {
        public string RoleName { get; set; }
    }
}
