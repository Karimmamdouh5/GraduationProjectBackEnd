using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        public DateTime? InsertDate { get; set; } = DateTime.UtcNow.AddHours(2);
        public DateTime? UpdateDate { get; set; } = DateTime.UtcNow.AddHours(2);
        public DateTime? DeleteDate { get; set; } = DateTime.UtcNow.AddHours(2);
        [StringLength(100)]
        public string? InsertBy { get; set; }
        [StringLength(100)]
        public string? UpdateBy { get; set; }
        [StringLength(100)]
        public string? DeleteBy { get; set; }
    }
}
