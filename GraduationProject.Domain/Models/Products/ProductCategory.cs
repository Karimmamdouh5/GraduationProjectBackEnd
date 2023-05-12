using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Products
{
    [Table("Prod_ProductsCategories")]
    public class ProductCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public bool isPcComponent { get; set; }
    }
}
