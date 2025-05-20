using System.Linq.Expressions;

namespace ASPMVCRepositoryDemo.Respository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
    }
}
