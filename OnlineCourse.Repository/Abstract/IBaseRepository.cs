
namespace OnlineCourse.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        List<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicate);
        TEntity? Get(int id);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        bool Add(TEntity entity);
        bool AddRange(List<TEntity> entities);
        bool Remove(int id);
        bool RemoveRange(IEnumerable<TEntity> entities);
        bool Update(TEntity entity);
        bool Save();

    }
}
