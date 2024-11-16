namespace OnlineCourse.Entity
{
    public class CourseCategory
    {
        public int CourseCategoryId { get; set; }
        public  string CourseCategoryName { get; set; }
        public  string Icon { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        // Navigation properties
        public  IEnumerable<Course> Course { get; set; }
        public  Category Category { get; set; }
    }

}
