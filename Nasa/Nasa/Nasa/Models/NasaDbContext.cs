using Microsoft.EntityFrameworkCore;

namespace Nasa.Models
{
   

        public class NasaDbContext : DbContext
        {
            public NasaDbContext(DbContextOptions<NasaDbContext> options) : base(options)
            {

            }

            public DbSet<CorpoCeleste> CorpoCeleste { get; set; }
        }
    
}
