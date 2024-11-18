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
             _courseService.UpdateCourse(courseDto);
            return Ok("Kurs Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult RemoveCourse(int id)
        {
            _courseService.DeleteCourse(id);
            return Ok("Kurse Alanı Silindi");
        }
    }
}
