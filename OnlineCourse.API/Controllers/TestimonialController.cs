using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController(ITestimonialService testimonialService) : ControllerBase
    {
        private readonly ITestimonialService _testimonialService=testimonialService;
        [HttpGet]
        public IActionResult GetAllTestimonial()
        {
            var testimonialGetAll = _testimonialService.GetAllTestimonial();
            return Ok(testimonialGetAll);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var getById = _testimonialService.GetTestimonialById(id);
            return Ok(getById);
        }
        [HttpPost]
        public IActionResult AddTestimonial(TestimonialDto testimonialDto)
        {
            var testimonialAdded = _testimonialService.AddTestimonial(testimonialDto);
            return Ok(testimonialDto);
        }
        [HttpPut]
        public IActionResult TestimonialMessage(TestimonialDto testimonialDto)
        {
            _testimonialService.UpdateTestimonial(testimonialDto);
            return Ok("Referans Güncellendi");
        }
        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            _testimonialService.DeleteTestimonial(id);
            return Ok("Referans Alanı Silindi");
        }
    }
}
