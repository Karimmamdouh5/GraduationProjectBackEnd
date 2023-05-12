using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.Repos
{
    public class CategoriesRepository : ICategoriesRepository
    {
        public readonly ApplicationDbContext _context;
        public CategoriesRepository(ApplicationDbContext context)
        {
            _context = context;   
        }
        public async Task<List<ProductCategory>> ListOfCategories()
        {
            
                var data = _context.Set<ProductCategory>().ToList();
                return data;
            
        }
    }
}
