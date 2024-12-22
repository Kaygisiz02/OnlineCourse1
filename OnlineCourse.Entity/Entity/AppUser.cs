using Microsoft.AspNetCore.Identity;

namespace OnlineCourse.Entity.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string? ImageUrl {  get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<CourseRegister> CoursesRegisters { get; set; }
    }
}
 