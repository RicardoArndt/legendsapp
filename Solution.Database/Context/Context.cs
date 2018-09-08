using Solution.Database.Domain;
using Solution.Database.Entities.Champions;
using System.Data.Entity;

namespace Solution.Database.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(): base("name=ConnDB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChampionConfiguration());
        }

        public DbSet<Champion> Champion { get; private set; }
    }
}
