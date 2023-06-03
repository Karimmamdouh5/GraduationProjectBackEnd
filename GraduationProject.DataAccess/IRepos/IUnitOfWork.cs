using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.IRepos
{
    public interface IUnitOfWork:IDisposable
    {
        IProductsRepository Products { get; }
        ICategoriesRepository Categories { get; }
        IComputersRepository Computers { get; }
        ICustomerRepository Customers { get; }
    }
}
