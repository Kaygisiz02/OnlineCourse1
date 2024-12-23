using Microsoft.AspNetCore.Identity;
namespace OnlineCourse.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName {  get; set; }  
        public string LastName { get; set; }
        public string? ImmageUrl {  get; set; }
        public List<CourseRegister> courseRegisters { get; set; }
        public List<Course> Courses { get; set; }
    }
}
