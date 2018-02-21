using DataAccess.Entities;
using DataAccess.MappingConfigurations;
using Microsoft.Practices.Unity;
using System.Data.Entity;

namespace DataAccess
{
    public class ArtistDbContext : DbContext
    {
        public ArtistDbContext([Dependency("DbConnectionString")] string connectionString)
            : base(connectionString)
        { }

        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistMappingConfiguration());
        }
    }
}
