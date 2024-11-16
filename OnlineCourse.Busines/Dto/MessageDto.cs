using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Busines
{
    public class MessageDto
    {
        [Key]
        public int MesageId { get; set; }
        public string MessageName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
