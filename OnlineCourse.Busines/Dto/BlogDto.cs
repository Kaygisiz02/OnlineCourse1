namespace OnlineCourse.Busines
{
    public class BlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogCreatedDate { get; set; }=DateTime.Now;
        public int BlogCategoryId { get; set; }
        public BlogCategoryDto? BlogCategory { get; set; }
    }
}
