namespace OnlineCourse.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public  string CategoryName { get; set; }
        public  string Icon {  get; set; }
        public  string Description { get; set; }
        public bool IsShown {  get; set; }
        public  IEnumerable<Course> Courses { get; set; }
    }

}
