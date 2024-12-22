namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController(ICourseCategoryService courseCategoryService) : ControllerBase
    {
        readonly ICourseCategoryService _courseCategoryService= courseCategoryService;

        [HttpGet]
        public IActionResult GetAll()
        {
            var getAll=_courseCategoryService.GetAllCourseCategory();
            return Ok(getAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById=_courseCategoryService.GetCourseCategoryById(id);
            if (getById == null)
            {
                return NotFound("Kurs Kategorisi Bulunamadı");
            }
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult Add(CourseCategoryDto courseCategory)
        {
            var add = _courseCategoryService.AddCourseCategory(courseCategory);
            return Ok(add);
        }
        [HttpPut]
        public IActionResult Update(CourseCategoryDto courseCategory)
        {
            var update=_courseCategoryService.UpdateCourseCategory(courseCategory);
            if (!update)
            {
                return BadRequest("Kurs Kategorisi güncellenemedi");
            }
            return Ok("Kurs Kategorisi Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_courseCategoryService.RemoveCourseCategory(id);
            if (!remove)
            {
                return NotFound("Kurs Kategorisi Silinemedi veya Bulunamadı");
            }
            return Ok("Kurs Kategorisi Silindi");
        }
        [HttpGet("ShowOnHome/{id}")]
        public IActionResult ShowOnHome(int id)
        {
            _courseCategoryService.TShowOnHome(id);
            return Ok("Ana Sayfada Gösteriliyor");
        }

        [HttpGet("DontShowOnHome/{id}")]
        public IActionResult DontShowOnHome(int id)
        {
            _courseCategoryService.TDontShowOnHome(id);
            return Ok("Ana Sayfada Gösterilmiyor");
        }

        [HttpGet("GetActiveCategory")]
        public IActionResult GetActiveCategory()
        {
            var values = _courseCategoryService.GetFiterCourseCategory(x=>x.IsShown==true);
            return Ok(values);
        }

    }
}
