using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Products
{
    [Table("Prod_ShopProducts")]
    public class ShopProduct
    {
        [Column("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public virtual ProductCategory Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
