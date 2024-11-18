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
             _categoryService.UpdateCategory(category);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _categoryService.RemovCategoty(id);
            return Ok(id);
        }
    }
}
