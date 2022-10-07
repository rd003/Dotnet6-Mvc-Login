using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Principal;

namespace Dotnet6MvcLogin.Repositories.Abstract
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        T? FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
