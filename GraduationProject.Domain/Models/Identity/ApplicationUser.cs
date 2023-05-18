using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProject.Domain.Models.Identity
{
    public class ApplicationUser: Microsoft.AspNetCore.Identity.IdentityUser
    {
        [System.ComponentModel.DataAnnotations.Required, MaxLength(100)]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required, MaxLength(100)]

        public string LastName { get; set; }
        public byte[]? ProfilePicture { get; set; }

    }
}
