using Azure;
using GraduationProject.Domain.Models.Identity;
using GraduationProject.Domain.ViewModels;
using GraduationProject.Domain.ViewModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.IServices
{
    public interface IUserService
    {
        Task<Domain.ViewModels.Response<string>> AddUserAsync(AddUserRequest user);
    }
}
