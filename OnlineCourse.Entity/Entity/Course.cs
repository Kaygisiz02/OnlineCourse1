namespace OnlineCourse.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
        public int? AppUserId {  get; set; }
        public AppUser AppUsers {  get; set; }
        public List<CourseRegister> courseRegisters { get; set; }
    }

}
