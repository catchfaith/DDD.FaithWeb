using FaithBlog.Domain.Entities;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Domain.Interfaces
{
    public interface IBaseRepository<T,Tid> where T : class, new()
    {
        Task<T> GetByIdAsync(Tid id);

        Task<bool> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(Tid id);

        Task<List<T>> QueryAsync(Expression<Func<T, bool>> predicate);

        Task<(List<T> Items, int Total)> QueryPageAsync(
            Expression<Func<T, bool>> predicate,
            int pageIndex,
            int pageSize);
    }
}
