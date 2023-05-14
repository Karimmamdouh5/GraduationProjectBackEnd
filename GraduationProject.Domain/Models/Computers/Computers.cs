using GraduationProject.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Computers
{
    [Table("Comp_CompComputers")]
    public class Computers:BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual Purposes Purpose { get; set; }
        public bool isPc { get; set; } = false;
        public bool isLaptop { get; set; }=false;
    }
}
