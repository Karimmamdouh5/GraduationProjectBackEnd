using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Computers;
using GraduationProject.Domain.Models.Products;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Services.IServices.ComputersServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.Services.ComputersServices
{
    public class ComputersService : IComputersService
    {
        public readonly IUnitOfWork _UnitOfWork;
        public ComputersService(IUnitOfWork UnitOfWork)
        {
            _UnitOfWork = UnitOfWork;   
        }
        public async Task<Response<Computers>> AddComputer(Computers item)
        {
            
            try
            {
                var exist = await _UnitOfWork.Computers.ExistAsync(x=>x.Name==item.Name);
                if (exist)
                {
                    return new Response<Computers>()
                    {
                        IsSuccess = false,
                        Message = "This Computer is already Exist"
                    };

                }
                var data = _UnitOfWork.Computers.Add(item);
                return new Response<Computers>() { IsSuccess = true, Message = "Computer Added Successfully" };
                
            }
            catch (Exception ex)
            {

                return new Response<Computers>() {IsSuccess=false,Message=ex.Message };
            }
            
        }

        public async Task<Response<Computers>> FindComputer(Expression<Func<Computers, bool>> filter)
        {
            try
            {
                var result = await _UnitOfWork.Computers.find(filter);
                if (result != null)
                {
                    return new Response<Computers>() { Data = result, IsSuccess = true, };
                }
                else
                {
                    return new Response<Computers>() { IsSuccess = false, Message = "No data found" };
                }
            }
            catch (Exception ex)
            {

                return new Response<Computers>() { IsSuccess = false, Message = ex.Message };
            }

        }

        public async Task<Response<List<Purposes>>> GetAllCompPurposes()
        {
            try
            {
                var data = await _UnitOfWork.Computers.GetAllComputerPurposes();
                if (data != null)
                return new Response<List<Purposes>>() { Data = data, IsSuccess=true };

                return new Response<List<Purposes>>() {Message="No data found",IsSuccess=false};
            }
            catch (Exception ex)
            {

                return  new Response<List<Purposes>>() { IsSuccess = false, Message = ex.Message};
            }

        }

        public async Task<Response<List<Computers>>> GetAllComputers()
        {
            try
            {
                var result = await _UnitOfWork.Computers.GetAll();
                if (result != null)
                {
                    return new Response<List<Computers>>()
                    {
                        Data = result,
                        IsSuccess = true,
                    };
                }
                else
                {
                    return new Response<List<Computers>>()
                    {
                        IsSuccess = false,
                        Message = "No data found"
                    };
                }
            }
            catch (Exception ex)
            {

                return new Response<List<Computers>>() { IsSuccess = false, Message = ex.Message };
            }
        }

        public Response<Computers> UpdateComputer(Computers item)
        {
            try
            {
                var result = _UnitOfWork.Computers.Update(item);
                return new Response<Computers>() { Data = result, IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new Response<Computers>() { IsSuccess = false, Message = ex.Message };
            }
        }
    }
}
