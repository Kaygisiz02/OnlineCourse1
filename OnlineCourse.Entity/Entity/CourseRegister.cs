namespace OnlineCourse.Entity
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }
        public int AppUserId { get; set; }
        public int CourseId { get; set; }
        public AppUser AppUsers {  get; set; }
        public Course Courses {  get; set; }
    }

}
