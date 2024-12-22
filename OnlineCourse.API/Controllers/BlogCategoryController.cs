using OnlineCourse.Entity;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController(IBlogCategoryService blogCategoryService,IMapper mapper) : ControllerBase
    {
        readonly IBlogCategoryService _blogCategoryService=blogCategoryService;
        readonly IMapper _mapper = mapper;
        [HttpGet]
        public IActionResult GetAll()
        {
            var getAll=_blogCategoryService.GetAllBlogCategories();
            return Ok(getAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getId=_blogCategoryService.GetBlogCategoryById(id);
            if (getId == null)
            {
                return NotFound("Blog Kategory alanı bulunamadı");
            }
            return Ok(getId);
        }
        [HttpPost]
        public IActionResult Add(BlogCategoryDto blogCategoryDto)
        {
            var add=_blogCategoryService.AddBlogCategory(blogCategoryDto);
            return Ok(add);
        }
        [HttpPut]
        public IActionResult Update(BlogCategoryDto blogCategoryDto)
        {
            var update=_blogCategoryService.UpdateBlogCategory(blogCategoryDto);
            if (!update)
            {
                return BadRequest("Blog Kategory alanı silinemedi veya bulunamadı");
            }
            return Ok("Blog Kategory Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_blogCategoryService.DeleteBlogCategory(id);
            if (!remove)
            {
                return NotFound("Blok Kategory alanı silinemedi veya bulunamadı");
            }
            return Ok("Blok Kategory Alanı Silindi");
        }
    }
}
