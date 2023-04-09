using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Products;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.Services
{
    public class ProductsService : IProductsService
    {
        public readonly IUnitOfWork _UnitOfWork;

        public ProductsService(IUnitOfWork UnitOfWork)
        {

            _UnitOfWork = UnitOfWork;
        }
      
        public async Task<Response<ShopProduct>> AddProduct(ShopProduct item)
        {
            try
            {
                var exist = await _UnitOfWork.Products.ExistAsync(x => x.Name == item.Name);
                if (!exist)
                {
                    var result = await _UnitOfWork.Products.Add(item);
                    return new Response<ShopProduct>()
                    {
                        Data = result,
                        IsSuccess = true,
                    };
                }
                else
                {
                    return new Response<ShopProduct>()
                    {
                        IsSuccess = false,
                        Message="Product is already exist",
                    };
                }

            }
            catch (Exception ex)
            {
                return new Response<ShopProduct>()
                {
                    IsSuccess = false,
                    Message=ex.Message,
                };
            }

        }

        public async Task<Response<ShopProduct>> FindProduct(Expression<Func<ShopProduct, bool>> filter)
        {
            var result = await _UnitOfWork.Products.find(filter);
            if (result!=null)
            {
                return new Response<ShopProduct>() { Data = result, IsSuccess = true, };
            }
            else
            {
                return new Response<ShopProduct>() {  IsSuccess = false,Message="No data found" };
            }
        }

        public async Task<Response<List<ShopProduct>>> GetAllProducts()
        {
            try
            {
                var result = await _UnitOfWork.Products.GetAll();
                if (result!=null)
                {
                    return new Response<List<ShopProduct>>()
                    {
                        Data = result,
                        IsSuccess = true,
                    };
                }
                else
                {
                    return new Response<List<ShopProduct>>()
                    {
                        IsSuccess = false,
                        Message="No data found"
                    };
                }
            }
            catch (Exception ex)
            {

                return new Response<List<ShopProduct>>()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

        }

        public Response<ShopProduct> UpdateProduct(ShopProduct item)
        {
            try
            {
                var result = _UnitOfWork.Products.Update(item);
                return new Response<ShopProduct>() { Data = result, IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<ShopProduct>() { IsSuccess = false,Message=ex.Message };
            }
        }
    }
}
