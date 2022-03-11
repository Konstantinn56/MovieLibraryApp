using Microsoft.EntityFrameworkCore;
using Data.Model;

namespace Data
{
    /// <summary>
    /// Account Database Context
    /// </summary>
    public partial class ApplicationContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationContext()
        {
            // Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Accounts Table
        /// </summary>
        public virtual DbSet<Account> Accounts { get; set; } = null!;

        /// <summary>
        /// Genres Table
        /// </summary>
        public virtual DbSet<Genre> Genres { get; set; } = null!;

        /// <summary>
        /// Movies Table
        /// </summary>
        public virtual DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// Favourite Movies Table
        /// </summary>
        public DbSet<AccountMovies> AccountsMovies { get; set; }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MLibraryDB;Integrated Security=True;";
                optionsBuilder.UseSqlServer(connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(u => u.Username, "Admin")
                    .IsUnique();

                entity.Property(e => e.AId).HasColumnName("Id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Username");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Password");

                entity.Property(e => e.RecoveryKey).HasColumnName("Recovery Key");

            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GId)
                    .HasName("pk_genre_id");

                entity.Property(e => e.GId).HasColumnName("id_genre");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MId)
                    .HasName("pk_movies_id");

                entity.Property(e => e.MId).HasColumnName("id_movie");
            });
        }
    }
}
