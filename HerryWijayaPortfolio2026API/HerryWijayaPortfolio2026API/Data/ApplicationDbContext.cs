
using HerryWijayaPortfolio2026API.Project2JwtAuthentication.Model;
using Microsoft.EntityFrameworkCore;

namespace HerryWijayaPortfolio2026API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
        {
        }
        //project2
        public DbSet<User> Users { get; set; }
    }
}
