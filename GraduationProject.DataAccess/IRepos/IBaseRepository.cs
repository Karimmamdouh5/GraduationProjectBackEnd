using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.IRepos
{
    public interface IBaseRepository <T> where T : class
    {
        public Task<List<T>> GetAll();
        public Task<T> find(Expression<Func<T, bool>> filter);
        public Task<T> Add(T item);
        public T Update(T item);
        Task<bool> ExistAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool ignoreQueryFilters = false);

    }
}
