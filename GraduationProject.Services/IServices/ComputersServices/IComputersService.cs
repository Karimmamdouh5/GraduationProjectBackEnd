using GraduationProject.Domain.Models.Computers;
using GraduationProject.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Services.IServices.ComputersServices
{
    public interface IComputersService
    {
        Task<Response<List<Computers>>> GetAllComputers();
        Task<Response<Computers>> FindComputer(Expression<Func<Computers, bool>> filter);
        Task<Response<Computers>> AddComputer(Computers item);
        Response<Computers> UpdateComputer(Computers item);

        Task<Response<List<Purposes>>>GetAllCompPurposes();
    }
}
