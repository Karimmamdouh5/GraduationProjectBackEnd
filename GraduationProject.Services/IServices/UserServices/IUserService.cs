using GraduationProject.Domain.Models.Identity;
using GraduationProject.Domain.Models.Persons;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Domain.ViewModels.Identity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.IServices.UserServices
{
    public interface IUserService
    {
        Task<Response<string>> AddUserAsync(AddUserRequest user, IFormFile? image);
        Task<Response<ApplicationUser>> UploadPhoto(IFormFile image, string Email);
        Task<Response<Customer>> AddCustomer(AddUserRequest user, IFormFile? image);
    }
}
