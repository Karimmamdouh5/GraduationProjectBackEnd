using GraduationProject.Domain.Models.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.IRepos
{
    public interface IComputersRepository:IBaseRepository<Computers>
    {
        public Task<List<Purposes>> GetAllComputerPurposes();

    }
}
