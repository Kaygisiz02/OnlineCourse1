using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Entity
{
    public static class OnlineCourseDummyData
    {
        public static void Seed()
        {
            // Dynamic Categories with More Specific Details
            var categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Web Development", Icon = "web_icon.png", Description = "Master front-end and back-end development.", IsShown = true },
            new Category { CategoryId = 2, CategoryName = "Machine Learning", Icon = "ml_icon.png", Description = "Explore AI and data-driven techniques.", IsShown = true },
            new Category { CategoryId = 3, CategoryName = "UI/UX Design", Icon = "uiux_icon.png", Description = "Create stunning and user-friendly designs.", IsShown = true },
            new Category { CategoryId = 4, CategoryName = "Project Management", Icon = "pm_icon.png", Description = "Develop leadership and project handling skills.", IsShown = false },
            new Category { CategoryId = 5, CategoryName = "Cloud Computing", Icon = "cloud_icon.png", Description = "Learn AWS, Azure, and cloud-native technologies.", IsShown = true }
        };

            // Dynamic Courses with Varied Pricing and Random Assignments
            var courses = new List<Course>();
            for (int i = 1; i <= 25; i++)
            {
                var randomCategoryId = (i % 5) + 1;
                courses.Add(new Course
                {
                    CourseId = i,
                    CourseName = $"Course {i} in {categories[randomCategoryId - 1].CategoryName}",
                    Title = $"Comprehensive Guide to {categories[randomCategoryId - 1].CategoryName} {i}",
                    Description = $"This course covers advanced {categories[randomCategoryId - 1].CategoryName} topics with practical examples.",
                    ImageUrl = $"course-{i}.jpg",
                    Price = (decimal)(50 + i * 7.5), // Incremental pricing
                    CategoryId = randomCategoryId,
                    IsShown = i % 3 != 0 // Hide every 3rd course
                });
            }

            // Enhanced Contact Information
            var contacts = new List<Contact>
        {
            new Contact { ContactId = 1, MapUrl = "https://maps.google.com/example1", Adress = "456 Developer Lane, Tech City, USA", PhoneNumber = "+1-800-456-7890", Email = "info@webcourses.com" },
            new Contact { ContactId = 2, MapUrl = "https://maps.google.com/example2", Adress = "789 Innovation Park, Data City, UK", PhoneNumber = "+44-123-456-7890", Email = "support@datacourses.com" }
        };

            // Diverse Messages
            var messages = new List<Message>
        {
            new Message { MesageId = 1, MessageName = "Alice Brown", Email = "alice.b@example.com", Subject = "Feedback on UI/UX Course", Content = "The UI/UX course exceeded my expectations! Great examples and practical tips." },
            new Message { MesageId = 2, MessageName = "Bob Carter", Email = "bob.c@example.com", Subject = "Enrollment Help", Content = "I'm having trouble enrolling in the Cloud Computing course. Can you assist?" },
            new Message { MesageId = 3, MessageName = "Chris Davies", Email = "chris.d@example.com", Subject = "Request for Discount", Content = "Are there any discounts available for the Machine Learning courses?" }
        };

            // More Social Media Links
            var socialMedia = new List<SocialMedia>
        {
            new SocialMedia { SocialMediaId = 1, Icon = "facebook.png", UrlLink = "https://facebook.com/techacademy", Title = "Facebook" },
            new SocialMedia { SocialMediaId = 2, Icon = "twitter.png", UrlLink = "https://twitter.com/techacademy", Title = "Twitter" },
            new SocialMedia { SocialMediaId = 3, Icon = "linkedin.png", UrlLink = "https://linkedin.com/company/techacademy", Title = "LinkedIn" },
            new SocialMedia { SocialMediaId = 4, Icon = "youtube.png", UrlLink = "https://youtube.com/techacademy", Title = "YouTube" }
        };

            // Diverse Subscribers
            var subscribes = new List<Subscribe>();
            for (int i = 1; i <= 15; i++)
            {
                subscribes.Add(new Subscribe
                {
                    SubscribeId = i,
                    Email = $"subscriber{i}@example.com",
                    IsActive = i % 2 == 0 // Alternate active/inactive
                });
            }

            // Realistic Testimonials
            var testimonials = new List<Testimonial>
        {
            new Testimonial { TestimonialId = 1, TestimonialName = "Emily Green", ImageUrl = "testimonial1.jpg", Comment = "The Project Management course helped me lead my first team successfully!", Star = 5 },
            new Testimonial { TestimonialId = 2, TestimonialName = "Frank Harris", ImageUrl = "testimonial2.jpg", Comment = "Great content but needs better practical examples.", Star = 4 },
            new Testimonial { TestimonialId = 3, TestimonialName = "Grace White", ImageUrl = "testimonial3.jpg", Comment = "The Machine Learning course is phenomenal! Learned so much.", Star = 5 }
        };

            // Output to Console for Verification
            Console.WriteLine("Enhanced Dummy Data Created Successfully.");
        }
    }
}
