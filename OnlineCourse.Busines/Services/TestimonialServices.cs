using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Busines
{
    public class TestimonialServices(ITestimonialRepository testimonialRepository, IMapper mapper) : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository=testimonialRepository;
        private readonly IMapper _mapper=mapper;
        public bool AddTestimonial(TestimonialDto testimonialDto)
        {
            var added = _mapper.Map<Testimonial>(testimonialDto);
            return _testimonialRepository.Add(added);
        }

        public bool DeleteTestimonial(int id)
        {
            return _testimonialRepository.Remove(id);
        }

        public IEnumerable<TestimonialDto> GetAllTestimonial()
        {

            var getAll = _testimonialRepository.GetAll();
            return _mapper.Map<List<TestimonialDto>>(getAll);
        }

        public TestimonialDto GetTestimonialById(int id)
        {
            var getById = _testimonialRepository.Get(id);
            return _mapper.Map<TestimonialDto>(getById);
        }

        public bool UpdateTestimonial(TestimonialDto testimonialDto)
        {
            var testimonialUpdate = _testimonialRepository.Get(testimonialDto.TestimonialId);
            if (testimonialUpdate == null)
            {
                return false;
            }
            _mapper.Map(testimonialUpdate, testimonialDto);
            return _testimonialRepository.Update(testimonialUpdate);
        }
    }
}
