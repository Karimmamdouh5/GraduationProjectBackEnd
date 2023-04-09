using Azure;
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
    public class ProductsRepository:BaseRepository<ShopProduct>,IProductsRepository
    {
        protected readonly ApplicationDbContext _context;
        public ProductsRepository(ApplicationDbContext context):base(context) { }

    }
}
