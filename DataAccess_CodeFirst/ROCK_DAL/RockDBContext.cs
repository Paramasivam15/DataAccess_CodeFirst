using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Rock_Model;
using System.Data.Entity.Infrastructure;

namespace ROCK_DAL
{
    public class RockDBContext : DbContext 
    {
        public RockDBContext()
            : base("Name=db_the_recsEntities")
        {


        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_the_comments>()
              .HasKey(o => o.ID);

            modelBuilder.Entity<tb_the_recs>()
             .HasKey(o => o.ID);

            modelBuilder.Entity<tb_the_comments>()
            .HasRequired<tb_the_recs>(s =>
            s.tb_the_recs)
            .WithMany(s => s.tb_the_comments)
            .HasForeignKey(s => s.rec_the_Id);

        }


        public DbSet<tb_the_comments> tb_the_comments { get; set; }
        public DbSet<tb_the_recs> tb_the_recs { get; set; }

    }
}
