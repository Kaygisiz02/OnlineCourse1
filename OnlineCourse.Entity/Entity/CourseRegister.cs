using OnlineCourse.Entity.Entity;

namespace OnlineCourse.Entity
{
    public class CourseRegister
    {

        public int CourseRegisterId { get; set; }
        public  int AppUserId { get; set; }
        public  AppUser AppUser { get; set; }
        public int CourseId {  get; set; }
        public  Course Courses { get; set; }
    }

}
