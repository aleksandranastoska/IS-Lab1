using Labs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Labs.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TheatreShow> TheatreShows { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
