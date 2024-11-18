using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController(ITestimonialService testimonialService) : ControllerBase
    {
        readonly ITestimonialService _testimonialService = testimonialService;

        [HttpGet]
        public IActionResult GetAll()
        {
            var testimonials = _testimonialService.GetAllTestimonial();
            return Ok(testimonials);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var testimonial = _testimonialService.GetTestimonialById(id);
            return Ok(testimonial);
        }

        [HttpPost]
        public IActionResult Add(TestimonialDto testimonialDto)
        {
            var addedTestimonial = _testimonialService.AddTestimonial(testimonialDto);
            return Ok(addedTestimonial);
        }

        [HttpPut]
        public IActionResult Update(TestimonialDto testimonialDto)
        {
            _testimonialService.UpdateTestimonial(testimonialDto);
            return Ok("Referans Bilgisi Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _testimonialService.DeleteTestimonial(id);
            return Ok("Referans Bilgisi Silindi");
        }
    }

}
