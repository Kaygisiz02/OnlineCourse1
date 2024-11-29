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
            var getById = _testimonialService.GetTestimonialById(id);
            if (getById == null)
            {
                return NotFound("Referans Alaı Bulunamadı");
            }
            return Ok(getById);
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
            var update=_testimonialService.UpdateTestimonial(testimonialDto);
            if (!update)
            {
                return BadRequest("Referans Bilgisi Güncellenemedi");
            }
            return Ok("Referans Bilgisi Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var remove=_testimonialService.DeleteTestimonial(id);
            if (!remove)
            {
                return NotFound("Referans Alanı Silinemedi veya Bulunamadı")
            }
            return Ok("Referans Bilgisi Silindi");
        }
    }

}
