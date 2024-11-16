using AutoMapper;
using OnlineCourse.Entity;
using OnlineCourse.Repository;
namespace OnlineCourse.Busines
{
    public class BlogCategoryService(IBlogCategoryRepository blogCategoryRepository,IMapper mapper) : IBlogCategoryService
    {
        readonly IBlogCategoryRepository _blogCategoryRepository=blogCategoryRepository;
        readonly IMapper _mapper=mapper;
        public bool AddBlogCategory(BlogCategoryDto blogCategory)
        {
            var aded=_mapper.Map<BlogCategory>(blogCategory);
            return _blogCategoryRepository.Add(aded);
        }

        public bool DeleteBlogCategory(int id)
        {
          return  _blogCategoryRepository.Remove(id);
            
        }

        public IEnumerable<BlogCategoryDto> GetAllBlogCategories()
        {
            var getAll=_blogCategoryRepository.GetAll();
            return _mapper.Map<List<BlogCategoryDto>>(getAll);
        }

        public BlogCategoryDto GetBlogCategoryById(int id)
        {
            var getId=_blogCategoryRepository.Get(id);
            return _mapper.Map<BlogCategoryDto>(getId);
        }

        public bool UpdateBlogCategory(BlogCategoryDto blogCategory)
        {
            var update = _blogCategoryRepository.Get(blogCategory.BlogCategoryId);
            if (update == null)
            {
                return false;
            }
            _mapper.Map(blogCategory, update);
            return _blogCategoryRepository.Update(update);
        }
    }
}
