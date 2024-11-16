namespace OnlineCourse.Entity
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public  string BlogCategoryName { get; set; }
        public  string Description { get; set; }
        public  IEnumerable<Blog> Blogs{ get; set; }
    }

}
