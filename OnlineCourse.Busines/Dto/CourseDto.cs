using OnlineCourse.Entity;

namespace OnlineCourse.Busines
{
    public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsShown { get; set; }
    }
}
