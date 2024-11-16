using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Entity
{
    public class Message
    {
        [Key]
        public int MesageId { get; set; }
        public  string MessageName { get; set; }
        public  string Email { get; set; }
        public  string Subject { get; set; }
        public  string Content { get; set; }
    }

}
