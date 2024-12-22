namespace OnlineCourse.Busines
{
    public class CategoryService(ICategoryRepository categoryRepository,IMapper mapper) : ICategoryService
    {
        readonly ICategoryRepository _categoryRepository=categoryRepository;
        readonly IMapper _mapper=mapper;
        public bool AddCategory(CategoryDto category)
        {
            var categoryAdded=_mapper.Map<Category>(category);
            return _categoryRepository.Add(categoryAdded);
            
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            var getAll=_categoryRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryDto>>(getAll);
        }

        public CategoryDto GetCategoryById(int id)
        {
            var getById = _categoryRepository.Get(id);
            return _mapper.Map<CategoryDto>(getById);
             
        }

        public bool RemovCategoty(int id)
        {
            return _categoryRepository.Remove(id);
        }

        public bool UpdateCategory(CategoryDto category)
        {
           var categoryUpdate=_categoryRepository.Get(category.CategoryId);
            if (categoryUpdate == null)
            {
                return false; 
            }
            _mapper.Map(category,categoryUpdate);
            return _categoryRepository.Update(categoryUpdate);
        }
    }
}
