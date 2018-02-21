using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MappingConfigurations
{
    internal sealed class ArtistMappingConfiguration : EntityTypeConfiguration<Artist>
    {
        public ArtistMappingConfiguration()
        {
            HasKey(a => new { a.Name });

            Property(a => a.Name);
            Property(a => a.DateOfBirth);
            Property(a => a.LivingPlace);
            Property(a => a.Contact);
            Property(a => a.Movies);

            ToTable("Artist", "dbo");
        }
    }
}
