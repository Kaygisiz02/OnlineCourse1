namespace OnlineCourse.Busines
{
    public class CourseRegisterService(ICourseRegisterRepository courseRegister, IMapper mapper) : ICourseRegisterService
    {
        readonly ICourseRegisterRepository _courseRegister = courseRegister;
        readonly IMapper _mapper=mapper;
        public bool AddCategory(CourseRegisterDto category)
        {
            var categoryAdded=_mapper.Map<CourseRegister>(category);
            return _courseRegister.Add(categoryAdded);
            
        }

        public IEnumerable<CourseRegisterDto> GetAllCategories()
        {
            var getAll= _courseRegister.GetAll();
            return _mapper.Map<IEnumerable<CourseRegisterDto>>(getAll);
        }

        public CourseRegisterDto GetCategoryById(int id)
        {
            var getById = _courseRegister.Get(id);
            return _mapper.Map<CourseRegisterDto>(getById);
             
        }

        public bool RemovCategoty(int id)
        {
            return _courseRegister.Remove(id);
        }

        public bool UpdateCategory(CourseRegisterDto category)
        {
           var categoryUpdate= _courseRegister.Get(category.CourseRegisterId);
            if (categoryUpdate == null)
            {
                return false; 
            }
            _mapper.Map(category,categoryUpdate);
            return _courseRegister.Update(categoryUpdate);
        }
    }
}
