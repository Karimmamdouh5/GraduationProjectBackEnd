using GraduationProject.Domain.Models.Computers;
using GraduationProject.Domain.Models.Products;
using GraduationProject.Domain.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using GraduationProject.Domain.Models.Persons;

namespace GraduationProject.DataAccess.DbContexts
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("Users", "Security");
            builder.Entity<ApplicationUser>().Ignore(x => x.PhoneNumberConfirmed);
            builder.Entity<ApplicationUser>().Ignore(x => x.PhoneNumber);
            builder.Entity<IdentityRole>().ToTable("Roles", "Security");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Security");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Security");
        }

        #region DbSets
        // public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> categories { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
        public DbSet<Computers> Computers { get; set; }
        public DbSet<Purposes> Purposes { get; set; }
        public DbSet<Customer>Customers { get; set; }
        #endregion
    }
}
