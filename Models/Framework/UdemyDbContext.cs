namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UdemyDbContext : DbContext
    {
        public UdemyDbContext()
            : base("name=UdemyDbContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PassWord)
                .IsUnicode(false);
        }
    }
}
