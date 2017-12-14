namespace WebApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFModel : DbContext
    {
        public EFModel()
            : base("data source=universityprojects.database.windows.net;initial catalog=foosball2text;persist security info=True;user id=warhatch;password=Awalgato0;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Game> Games { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.LeftUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.RightUserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.TimePlayed)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
