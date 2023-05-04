namespace BlazorServerLearning.DataAccess
{
    public interface IRepository<TEntity, TId>
    {
        public IEnumerable<TEntity> GetAll();

        public TEntity GetById(TId id);
        public bool DeleteById(TId id);
        public TEntity Create(TEntity entity);
        public TEntity Update(TEntity entity);
    }
}
