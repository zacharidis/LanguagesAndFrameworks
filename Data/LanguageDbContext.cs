using Microsoft.EntityFrameworkCore;

namespace LanguagesAndFrameworks.Data
{
    public class LanguageDbContext : DbContext
    {
        public LanguageDbContext(DbContextOptions<LanguageDbContext> options) :base(options)
        {
            
        }


        public DbSet<Model.Domain.Language> Languages { get; set; }
        public DbSet<Model.Domain.Framework> Frameworks { get; set; }

        public DbSet<Model.Domain.Project> Projects { get; set; }
    }
}
