using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.Repos
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;
        public BaseRepository(ApplicationDbContext context)
        {
            _context= context;
            this.dbSet= context.Set<T>();
        }
        public async Task<T> Add(T item)
        {
            await dbSet.AddAsync(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<T> find(Expression<Func<T, bool>> filter)
        {
            var data =  await dbSet.FindAsync(filter);
            return data;
        }

        public async Task<List<T>> GetAll()
        {
            var data = _context.Set<T>().ToList();
            return data;
        }

        public T Update(T item)
        {
            dbSet.Update(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<bool> ExistAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, bool ignoreQueryFilters = false)
        {
            var entity = await dbSet.FindAsync(filter);
            return entity is not null;
        }
    }
}
