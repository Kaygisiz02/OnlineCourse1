namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(ICourseService courseService) : ControllerBase
    {
        readonly ICourseService _courseService= courseService;
        [HttpGet]
        public IActionResult GetAll()
        {
            var courseGetAll=_courseService.GetAllCourse();
            return Ok(courseGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById= _courseService.GetCourseById(id);
            if (getById == null)
            {
                return NotFound("Kurs Alanı Bulunamadı");
            }
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddCourse(CourseDto courseDto)
        {
            var courseAdded = _courseService.AddCourse(courseDto);

            return Ok(courseAdded);
        }
        [HttpPut]
        public IActionResult UpdateCourse(CourseDto courseDto)
        {
             var update=_courseService.UpdateCourse(courseDto);
            if (!update)
            {
                return BadRequest("Kurs Alanı güncellenemedi");
            }
            return Ok("Kurs Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveCourse(int id)
        {
            var remove=_courseService.DeleteCourse(id);
            if (!remove)
            {
                return NotFound("Kurs Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("Kurse Alanı Silindi");
        }
        [HttpGet("ShowOnHome/{id}")]
        public IActionResult ShowOnHome(int id)
        {
            _courseService.TShowOnHome(id);
            return Ok("Ana Sayfada Gösteriliyor.");
        }
        [HttpGet("DontShowOnHome/{id}")]
        public IActionResult DontShowOnHome(int id)
        {
            _courseService.TDontShowOnHome(id);
            return Ok("Ana Sayfada Gösterilmiyor.");
        }
        [HttpGet("GetActiveCourses")]
        public IActionResult GetActiveCourses()
        {
            var activeCourses = _courseService.GetAllFiltered(x => x.IsShown == true);
            return Ok(activeCourses);
        }
    }
}
