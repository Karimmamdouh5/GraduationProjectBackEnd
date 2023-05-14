using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Computers
{
    [Table("Comp_CompPurposes")]
    public class Purposes:BaseEntity
    {
        [Column("ID")]
        public int id { get; set; }
        public string Name { get; set; }
    }
}
