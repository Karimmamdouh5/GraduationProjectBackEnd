using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.Repos
{
    public class ComputersRepository:BaseRepository<Computers>,IComputersRepository
    {
        public readonly ApplicationDbContext _Context;
        public ComputersRepository(ApplicationDbContext Context):base(Context)
        {
            _Context = Context;
        }

        public async Task<List<Purposes>> GetAllComputerPurposes()
        {
           var data = _Context.Set<Purposes>();
           return data.ToList();
        }
    }
}
