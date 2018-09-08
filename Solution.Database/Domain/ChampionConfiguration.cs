using Solution.Database.Entities.Champions;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Database.Domain
{
    public class ChampionConfiguration : EntityTypeConfiguration<Champion>
    {
        public ChampionConfiguration()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties 
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Ative)
                .IsRequired();

            // Table and Maps 
            this.ToTable("Champion", "LegendsSolution");
            this.Property(t => t.Id).HasColumnName("COD_CHAMPION");
            this.Property(t => t.Name).HasColumnName("CHAMP_NAME");
            this.Property(t => t.Ative).HasColumnName("CHAMP_ATIVE");
        }
    }
}
