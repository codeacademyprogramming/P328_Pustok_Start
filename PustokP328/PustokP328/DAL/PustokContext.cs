using Microsoft.EntityFrameworkCore;
using PustokP328.Models;

namespace PustokP328.DAL
{
    public class PustokContext:DbContext
    {
        public PustokContext(DbContextOptions<PustokContext> options):base(options) { }

        public DbSet<Genre> Genres { get; set; }
    }
}
