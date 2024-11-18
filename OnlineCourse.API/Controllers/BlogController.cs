namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController(IBlogService blogService,IMapper mapper) : ControllerBase
    {
        readonly IBlogService _blogService=blogService;
        readonly IMapper _mapper=mapper;
        [HttpGet]
        public IActionResult GetAll()
        {
            var blog= _blogService.GetAllBlog();
            return Ok(blog);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            var blogId=_blogService.GetBlog(id);
            return Ok(blogId);
        }
        [HttpPost]
        public IActionResult Add(BlogDto blog)
        {
            var blogAdded= _blogService.AddBlog(blog);
         
            return Ok(blogAdded);
        }
        [HttpPut]
        public IActionResult Update(BlogDto blog)
        {
            _blogService.UpdateBlog(blog);
            return Ok("Blog Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _blogService.DeleteBlog(id);
            return Ok("Bol Alanı Silindi");

        }
    }
}
