namespace OnlineCourse.Busines
{
    public class CourseServices(ICourseRepository courseRepository, IMapper mapper) : ICourseService
    {
        readonly ICourseRepository _courseRepository = courseRepository;
        readonly IMapper _mapper = mapper;
        public bool AddCourse(CourseDto courseDto)
        {
            var added = _mapper.Map<Course>(courseDto);
            return _courseRepository.Add(added);

        }

        public bool DeleteCourse(int id)
        {
            return _courseRepository.Remove(id);
        }

        public IEnumerable<CourseDto> GetAllCourse()
        {
            var getAll = _courseRepository.GetAll();
            return _mapper.Map<IEnumerable<CourseDto>>(getAll);
        }

        public CourseDto GetCourseById(int id)
        {
            var getById = _courseRepository.Get(id);
            return _mapper.Map<CourseDto>(getById);
        }

        public bool UpdateCourse(CourseDto courseDto)
        {
            var courseUpdate = _courseRepository.Get(courseDto.CourseId);
            if (courseUpdate == null)
            {
                return false;
            }
            _mapper.Map(courseUpdate, courseDto);
            return _courseRepository.Update(courseUpdate);
        }
    }
}
