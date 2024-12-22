namespace OnlineCourse.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly OnlineCourseDbContext _dbContext;
        DbSet<TEntity> _dbset;
        public BaseRepository(OnlineCourseDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset=dbContext.Set<TEntity>();
        }
        public bool Add(TEntity entity)
        {
            _dbset.Add(entity);
            return Save();
        }

        public bool AddRange(List<TEntity> entities)
        {
           _dbset.AddRange(entities);
            return Save();
        }

        public TEntity? Get(int id)
        {
            return _dbset.Find(id);
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
          return _dbset.Where(predicate).FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            return _dbset.ToList();
        }

        public List<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate).ToList();
        }
         

        public bool Remove(int id)
        {
           var delete=_dbset.Find(id);
            if (delete != null) 
            {
             _dbset.Remove(delete);
                return Save();
            }
            return false;
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            if (entities != null)
            {
                _dbset.RemoveRange(entities);
                return Save();
            }
            return false;
        }

        public bool Save()
        {
            return _dbContext.SaveChanges()>0;
        }

        public bool Update(TEntity entity)
        {
            _dbContext.Update(entity);
            return Save();
        }
    }
}
