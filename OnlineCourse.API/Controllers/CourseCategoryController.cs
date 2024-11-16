using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            _courseCategoryService.UpdateCourseCategory(courseCategory);
            return Ok("Kurs Kategorisi Güncellendi");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.RemoveCourseCategory(id);
            return Ok("Kurs Kategorisi Silindi");
        }
        
    }
}
