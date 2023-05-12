using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.Repos
{
    public class UnitOfWork:IUnitOfWork
    {
        public readonly ApplicationDbContext _context;

        public IProductsRepository Products { get; private set; }
        public ICategoriesRepository Categories { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context= context;
            Products = new ProductsRepository(_context);
            Categories = new CategoriesRepository(_context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
