namespace OnlineCourse.Busines
{
    public class BlogService(IBlogRepository blogRepository, IMapper mapper) : IBlogService
    {
        private readonly IBlogRepository _blogRepository=blogRepository;
        private readonly IMapper _mapper=mapper;
        public bool AddBlog(BlogDto blog)
        {
           var blogAdd=_mapper.Map<Blog>(blog);
            return _blogRepository.Add(blogAdd);

        }

        public bool DeleteBlog(int id)
        {
           return _blogRepository.Remove(id);
        }

        public List<BlogDto> GetAllBlog()
        {
           var blogGet=_blogRepository.GetAll();
            return _mapper.Map<List<BlogDto>>(blogGet);
        }

        public BlogDto GetBlog(int id)
        {
            var BlogId= _blogRepository.Get(id);
            return _mapper.Map<BlogDto>(BlogId);
        }

        public bool UpdateBlog(BlogDto blogDto)
        {
            var blogUpdate = _blogRepository.Get(blogDto.BlogId);
            if (blogUpdate == null)
            {
                return false;
            }
            _mapper.Map(blogDto, blogUpdate);
            return _blogRepository.Update(blogUpdate);
        }
    }
}
