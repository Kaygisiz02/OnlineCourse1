﻿namespace OnlineCourse.Entity
{
    public class Blog
    {

        public int BlogId { get; set; }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  string ImageUrl { get; set; }
        public DateTime BlogCreatedDate { get; set; }
        public int BlogCategoryId { get; set; }
        // Navigation property
        public  BlogCategory BlogCategory { get; set; }
    }

}
