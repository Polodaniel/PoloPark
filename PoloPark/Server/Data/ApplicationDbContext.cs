using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PoloPark.Server.Model;

namespace PoloPark.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        #region Entidades
        //public DbSet<Empresa> Empresa { get; set; }
        #endregion

    }
}
