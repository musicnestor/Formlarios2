using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Formlarios2.Models 
{
   public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions option) : base(option)
        {
        }

        public DbSet<marcas> marcas { get; set; }
    }


}





