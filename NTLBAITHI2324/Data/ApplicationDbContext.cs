using Microsoft.EntityFrameworkCore;
using NTLBAITHI2324;

namespace ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        DbSet<NTL381Person> NTL381Person { get; set; } 
    }
}