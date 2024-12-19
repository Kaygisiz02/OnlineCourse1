namespace OnlineCourse.Entity
{
        public class CourseCategory
        {
            public int CourseCategoryId { get; set; }
            public string CourseCategoryName { get; set; }
            public string Icon { get; set; }
            public string Description { get; set; }
            public bool IsShown { get; set; }
            public List<Course> Courses { get; set; }
        }
}
