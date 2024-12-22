using OnlineCourse.Entity.Entity;

namespace OnlineCourse.Busines
{
    public class CourseRegisterDto
    {
        public int CourseRegisterId { get; set; }
        public int StudentId { get; set; }
        public string Icon { get; set; }
        public AppUser AppUser { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}
