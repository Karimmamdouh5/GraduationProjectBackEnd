using Azure;
using Castle.Core.Logging;
using Castle.Core.Smtp;
using GraduationProject.Domain.Models.Identity;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Domain.ViewModels.Identity;
using GraduationProject.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserEmailStore<ApplicationUser> _emailStore;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserStore<ApplicationUser> _userStore;



        public UserService(UserManager<ApplicationUser> userManager, IUserStore<ApplicationUser> userStore)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();

        }


        public async Task<Domain.ViewModels.Response<string>> AddUserAsync(AddUserRequest model)
            {

			try
			{
                var user = new ApplicationUser
                {
                    UserName = new MailAddress(model.Email).User,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                };

                //await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, model.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return new Domain.ViewModels.Response<string>() { Data = "User added successfully", IsSuccess = true };
                }
                else
                {
                    return new Domain.ViewModels.Response<string>() { Data = "A proplem happend please try again later", IsSuccess = false };

                }
            }
			catch (Exception ex)
			{

                return new Domain.ViewModels.Response<string>() { IsSuccess = false , Message=ex.Message};
            }
        }

        public IUserEmailStore<ApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ApplicationUser>)_userStore;
        }
    }
}
