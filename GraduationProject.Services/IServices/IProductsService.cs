using GraduationProject.Domain.Models.Products;
using GraduationProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.IServices
{
    public interface IProductsService
    {
        Task<Response<List<ShopProduct>>> GetAllProducts();
        Task<Response<ShopProduct>> FindProduct(Expression<Func<ShopProduct, bool>> filter);
        Task<Response<ShopProduct>> AddProduct(ShopProduct item);
        Response<ShopProduct> UpdateProduct(ShopProduct item);

        Task<Response<List<ProductCategory>>> ListOfCategories();
    }
}
