using OnlineCourse.Repository.Abstract;

namespace OnlineCourse.Busines
{
    public class TestimonialServices(ITestimonialRepository testimonialRepository, IMapper mapper) : ITestimonialService
    {
        readonly ITestimonialRepository _testimonialRepository = testimonialRepository;
        readonly IMapper _mapper = mapper;

        public bool AddTestimonial(TestimonialDto testimonialDto)
        {
            var addedTestimonial = _mapper.Map<Testimonial>(testimonialDto);
            return _testimonialRepository.Add(addedTestimonial);

        }

        public bool DeleteTestimonial(int id)
        {
            return _testimonialRepository.Remove(id);
        }

        public IEnumerable<TestimonialDto> GetAllTestimonial()
        {
            var getAllTestimonial = _testimonialRepository.GetAll();
            return _mapper.Map<IEnumerable<TestimonialDto>>(getAllTestimonial);
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
            _mapper.Map(testimonialDto, testimonialUpdate);
            return _testimonialRepository.Update(testimonialUpdate);
        }
    }
}
