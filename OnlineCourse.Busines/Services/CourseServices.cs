using System.Linq.Expressions;

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

        public List<CourseDto> GetAllCourse()
        {
            var getAll = _courseRepository.GetAll();
            return _mapper.Map<List<CourseDto>>(getAll);
        }

        public List<CourseDto> GetAllFiltered(Expression<Func<Course, bool>> predicate)
        {
            var getFiltered = _courseRepository.GetAllFiltered(predicate);
            return _mapper.Map<List<CourseDto>>(getFiltered);
        }

        public CourseDto GetCourseById(int id)
        {
            var getById = _courseRepository.Get(id);
            return _mapper.Map<CourseDto>(getById);
        }


        public void TDontShowOnHome(int id)
        {
            _courseRepository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseRepository.ShowOnHome(id);
        }

        public bool UpdateCourse(CourseDto courseDto)
        {
            var courseUpdate = _courseRepository.Get(courseDto.CourseId);
            if (courseUpdate == null)
            {
                return false;
            }
            _mapper.Map(courseDto, courseUpdate);
            return _courseRepository.Update(courseUpdate);
        }
    }
}
