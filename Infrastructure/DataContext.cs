namespace Infrastructure
{
    using Core.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="DataContext" />.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{DataContext}"/>.</param>
        public DataContext(DbContextOptions<DataContext> options)
                : base(options)
        {
        }

        /// <summary>
        /// The OnModelCreating.
        /// </summary>
        /// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.ID).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ProtfolioItem>().Property(x => x.ID).HasDefaultValueSql("NEWID()");


            modelBuilder.Entity<Owner>().HasData(
                new Owner() { ID = System.Guid.NewGuid() , Avater = "Tareq.jpg" , FullName = "Tareq Abou Hjileh" , Profil = ".NET 5 Full Stack Developer" }
                );
        }

        /// <summary>
        /// Gets or sets the Owner.
        /// </summary>
        public DbSet<Owner> Owner { get; set; }

        /// <summary>
        /// Gets or sets the protfolioItems.
        /// </summary>
        public DbSet<ProtfolioItem> protfolioItems { get; set; }
    }
}
