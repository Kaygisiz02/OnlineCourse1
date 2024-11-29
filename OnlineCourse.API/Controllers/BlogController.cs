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
            if (blogId == null)
            {
                return NotFound("Blog Alanı Bulunamadı");
            }
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
            var blogUpdate=_blogService.UpdateBlog(blog);
            if (!blogUpdate)
            {
                return BadRequest("Blog Alanı Güncellenemedi");
            }
            return Ok("Blog Alanı Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_blogService.DeleteBlog(id);
            if (!remove)
            {
                return NotFound("Blog Alanı Silinemedi veya Bulunamadı");
            }
            return Ok("Bol Alanı Silindi");

        }
    }
}
