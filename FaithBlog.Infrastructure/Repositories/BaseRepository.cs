using FaithBlog.Domain.Interfaces;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FaithBlog.Infrastructure.Repositories
{
    public class BaseRepository<T, Tid> : IBaseRepository<T, Tid> where T : class, new()
    {
        protected readonly ISqlSugarClient _db;

        public BaseRepository(ISqlSugarClient db)
        {
            _db = db;
        }
        public async Task<T> GetByIdAsync(Tid id)
        {
            return await _db.Queryable<T>().InSingleAsync(id);
        }

        public async Task<bool> AddAsync(T entity)
        {
            return await _db.Insertable(entity).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _db.Updateable(entity).ExecuteCommandAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Tid id)
        {
            return await _db.Deleteable<T>().In(id).ExecuteCommandAsync() > 0;
        }

        public async Task<List<T>> QueryAsync(Expression<Func<T, bool>> predicate)
        {
            return await _db.Queryable<T>().Where(predicate).ToListAsync();
        }

        public async Task<(List<T> Items, int Total)> QueryPageAsync(
            Expression<Func<T, bool>> predicate,
            int pageIndex,
            int pageSize)
        {
            RefAsync<int> total = 0;
            var items = await _db.Queryable<T>()
                                 .Where(predicate)
                                 .ToPageListAsync(pageIndex, pageSize, total);

            return (items, total);
        }
    }
}
