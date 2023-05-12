using GraduationProject.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.DataAccess.IRepos
{
    public interface ICategoriesRepository
    {

        public Task<List<ProductCategory>> ListOfCategories();

    }
}
