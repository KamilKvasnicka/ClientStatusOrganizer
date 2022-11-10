using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using ClientStatusOrganizer.Model;

namespace ClientStatusOrganizer.DataAccess
{
    public class ClientStatusOrganizerDbContext : DbContext
    {
        public ClientStatusOrganizerDbContext() : base("ClientStatusOrganizerDb")
        {

        }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           // modelBuilder.Configurations.Add(new ClientConfiguration());

            // modelBuilder.Entity<Client>()
            //.Property(f => f.ClientName)
            //.IsRequired()
            //.HasMaxLength(50);
        }
    }

  //  public class ClientConfiguration : EntityTypeConfiguration<Client>
  //  {
    //  public ClientConfiguration()
       // {
      //      Property(f => f.ClientName)
        //        .IsRequired()
          //      .HasMaxLength(50);
       // }

   // }
}
