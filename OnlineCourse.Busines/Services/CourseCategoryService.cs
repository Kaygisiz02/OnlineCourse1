using System.Linq.Expressions;
namespace OnlineCourse.Busines
{
    public class CourseCategoryService(ICourseCategoryRepository courseCategoryRepository,  IMapper mapper) : ICourseCategoryService
    {
        readonly ICourseCategoryRepository _courseCategoryRepository=courseCategoryRepository;
        readonly IMapper _mapper=mapper;
        public bool AddCourseCategory(CourseCategoryDto courseCategory)
        {
            var addCourseCategory= _mapper.Map<CourseCategory>(courseCategory);
            return _courseCategoryRepository.Add(addCourseCategory);
        }

        public List<CourseCategoryDto> GetAllCourseCategory()
        {
            var getAllCourseCategory= _courseCategoryRepository.GetAll();
            return _mapper.Map<List<CourseCategoryDto>>(getAllCourseCategory);
        }

        public List<CourseCategoryDto> GetAllFiltered(Expression<Func<CourseCategory, bool>> predicate)
        {
           var getAllFiltered = _courseCategoryRepository.GetAllFiltered(predicate);
            return _mapper.Map<List<CourseCategoryDto>>(getAllFiltered);
        }

        public CourseCategoryDto GetCourseCategoryById(int id)
        {
            var getCourseCategoryById= _courseCategoryRepository.Get(id);
            return _mapper.Map<CourseCategoryDto>(getCourseCategoryById);
        }


        public bool RemoveCourseCategory(int id)
        {
            return _courseCategoryRepository.Remove(id);

        }

        public void TDontShowOnHome(int id)
        {
            _courseCategoryRepository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _courseCategoryRepository.ShowOnHome(id);
        }

        public bool UpdateCourseCategory(CourseCategoryDto courseCategory)
        {
            var updateCourseCategory= _courseCategoryRepository.Get(courseCategory.CourseCategoryId);
            if (updateCourseCategory == null)
            {
                return false;
            }
            _mapper.Map(courseCategory,updateCourseCategory);
            return _courseCategoryRepository.Update(updateCourseCategory);
        }
    }
}
