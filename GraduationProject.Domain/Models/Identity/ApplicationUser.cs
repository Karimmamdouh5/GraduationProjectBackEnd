using GraduationProject.Domain.Models.Persons;
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
        public virtual Customer? Customer { get; set; }
    }
}
