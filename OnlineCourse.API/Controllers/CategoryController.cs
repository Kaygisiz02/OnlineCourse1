namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        readonly ICategoryService _categoryService=categoryService;
        [HttpGet]
        public ActionResult GetAll()
        {
            var getAll=_categoryService.GetAllCategories();
            return Ok(getAll);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var getById=_categoryService.GetCategoryById(id);
            if (getById == null)
            {
                return NotFound("Categori Alanı Bulunamadı");
            }
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddController(CategoryDto category)
        {
            var controllerAdd = _categoryService.AddCategory(category);
            return Ok(controllerAdd);
        }
        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            var update=_categoryService.UpdateCategory(category);
            if (!update)
            {
                return BadRequest("Categori Alanı güncellenemedi");
            }
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_categoryService.RemovCategoty(id);
            if (!remove)
            {
                return NotFound("Categori Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("Categori Alanı Silindi");
        }
    }
}
