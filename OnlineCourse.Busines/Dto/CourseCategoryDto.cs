using OnlineCourse.Entity;

namespace OnlineCourse.Busines
{
    public class CourseCategoryDto
    {
        public int CourseCategoryId { get; set; }
        public string CourseCategoryName { get; set; }
        public string Icon { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
    }
}
