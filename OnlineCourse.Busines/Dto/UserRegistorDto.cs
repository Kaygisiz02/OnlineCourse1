using System.ComponentModel.DataAnnotations;

namespace OnlineCourse.Busines
{
    public class UserRegistorDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler Birbiriyle Uyumlu Değil")]
        public string ConfirmPassword {  get; set; }
    }
}
