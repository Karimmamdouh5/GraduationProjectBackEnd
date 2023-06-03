using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Persons
{
    [Table("Persons_Customers")]
    public class Customer:BaseEntity
    {
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]

        public string LastName { get; set; }

        public byte[]? ProfilePicture { get; set; }

        public string? LandLineNumber { get; set; }

        public string PhoneNumber { get; set; }

    }
}
