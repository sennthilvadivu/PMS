using PMS.Core.Domain.Entities;
using PMS.Core.Domain.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Persistence
{
    public class PMSContext : DbContext
    {
        public PMSContext() : base("name=PMSContext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CreateDatabaseIfNotExists<PMSContext>());
        }

        public virtual DbSet<Venture> Ventures { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        //public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CourseConfiguration());
            Database.SetInitializer<PMSContext>(null);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new VentureMap());
        }
    }
}
