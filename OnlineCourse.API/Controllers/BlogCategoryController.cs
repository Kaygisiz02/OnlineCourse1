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
            _blogCategoryService.UpdateBlogCategory(blogCategoryDto);
            return Ok("Blog Kategory Alanı Güncellendi");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _blogCategoryService.DeleteBlogCategory(id);
            return Ok("Blok Kategory Alanı Silindi");
        }
    }
}
