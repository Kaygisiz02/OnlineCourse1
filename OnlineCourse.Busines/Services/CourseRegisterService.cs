using OnlineCourse.Repository;

namespace OnlineCourse.Busines
{
    public class CourseRegisterService(ICourseRegisterRepository courseRegisterRepository, IMapper mapper) : ICourseRegisterService
    {
        readonly ICourseRegisterRepository _courseRegisterRepository = courseRegisterRepository;
        readonly IMapper _mapper = mapper;
        public bool AddCategory(CourseRegisterDto category)
        {
            var categoryAdded = _mapper.Map<CourseRegister>(category);
            return _courseRegisterRepository.Add(categoryAdded);

        }

        public IEnumerable<CourseRegisterDto> GetAllCategories()
        {
            var getAll = _courseRegisterRepository.GetAll();
            return _mapper.Map<IEnumerable<CourseRegisterDto>>(getAll);
        }

        public CourseRegisterDto GetCategoryById(int id)
        {
            var getById = _courseRegisterRepository.Get(id);
            return _mapper.Map<CourseRegisterDto>(getById);

        }

        public bool RemovCategoty(int id)
        {
            return _courseRegisterRepository.Remove(id);
        }

        public bool UpdateCategory(CourseRegisterDto category)
        {
            var categoryUpdate = _courseRegisterRepository.Get(category.CourseRegisterId);
            if (categoryUpdate == null)
            {
                return false;
            }
            _mapper.Map(category, categoryUpdate);
            return _courseRegisterRepository.Update(categoryUpdate);
        }
    }
}
