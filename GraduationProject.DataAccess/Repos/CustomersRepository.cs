using GraduationProject.DataAccess.DbContexts;
using GraduationProject.DataAccess.IRepos;
using GraduationProject.Domain.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.Repos
{
    public class CustomersRepository:BaseRepository<Customer>,ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        public CustomersRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
