using Castle.Core.Logging;
using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Identity;
using GraduationProject.Domain.Models.Persons;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Domain.ViewModels.Identity;
using GraduationProject.Services.IServices;
using GraduationProject.Services.IServices.UserServices;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly Microsoft.AspNetCore.Identity.IUserEmailStore<ApplicationUser> _emailStore;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;
        private readonly Microsoft.AspNetCore.Identity.IUserStore<ApplicationUser> _userStore;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager, Microsoft.AspNetCore.Identity.IUserStore<ApplicationUser> userStore, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _unitOfWork = unitOfWork;

        }


        public async Task<Response<string>> AddUserAsync(AddUserRequest model, IFormFile? image)
        {
            

            try
            {

                var user = new ApplicationUser
                {
                    UserName = new MailAddress(model.Email).User,
                    Email = model.Email,

                };

                var result = await _userManager.FindByNameAsync(user.UserName);

                if (result!=null)
                {
                    return new Response<string>() { Message = "user is already exist", IsSuccess = false };
                }

                if (model.isCustomer)
                {
                    var data = await AddCustomer(model, image);
                    if (data.IsSuccess)
                    {
                        user.Customer = data.Data;
                        await _emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);
                        var NewUser = await _userManager.CreateAsync(user, model.Password);
                        if (NewUser.Succeeded)
                        {
                            return new Response<string>() { Message = "User added successfully", IsSuccess = true };
                        }
                        else
                        {
                            return new Response<string>() { Message = "A proplem happend please try again later", IsSuccess = false };

                        }
                    }
                    else
                    {
                        return new Response<string>() { Message = "A proplem happend please try again later", IsSuccess = false };
                    }

                }
                else
                {
                    return new Response<string>() { Message = "A proplem happend please try again later", IsSuccess = false };
                }
            }
            catch (Exception ex)
            {

                return new Response<string>() { IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<Response<ApplicationUser>> UploadPhoto(IFormFile image, string Email)
        {
            var user = await _userManager.FindByEmailAsync(Email);
            
            if (image != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await image.CopyToAsync(memoryStream);
                    user.Customer.ProfilePicture = memoryStream.ToArray();
                    _unitOfWork.Customers.Update(user.Customer);
                }
                return new Response<ApplicationUser> { Data = user, IsSuccess = true };

            }
            return new Response<ApplicationUser> { IsSuccess = false, Message = "no photo uploaded" };

        }

        public Microsoft.AspNetCore.Identity.IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (Microsoft.AspNetCore.Identity.IUserEmailStore<ApplicationUser>)_userStore;
        }

        public async Task<Response<Customer>> AddCustomer(AddUserRequest user,IFormFile? image)
        {
            try
            {
                var Customer = new Customer
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    LandLineNumber = user.LandLineNumber,
                };

                if (image != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        image.CopyToAsync(memoryStream);
                        Customer.ProfilePicture = memoryStream.ToArray();
                    }
                }
                var result = await _unitOfWork.Customers.Add(Customer);
                return new Response<Customer>() {Data=result,IsSuccess=true };

            }
            catch (Exception ex)
            {

                return new Response<Customer>() { Message=ex.Message, IsSuccess = false };
            }
        }
    }
}
