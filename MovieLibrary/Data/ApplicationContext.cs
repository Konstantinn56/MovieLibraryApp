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
        public virtual DbSet<AccountMovies> AccountsMovies { get; set; }

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

                entity.Property(e => e.AId)
                    .UseIdentityColumn()
                    .HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RecoveryKey).HasColumnName("recoveryKey");

                entity.HasData
                (
                    new Account {AId = 1, FirstName = "Konstatnin", LastName = "Balabanov", Username = "admin", Password = "admin", RecoveryKey = 100000 }
                );
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

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("titel");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.GenreId).HasColumnName("id_genre");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.YaerOfCreation).HasColumnName("year");

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasOne(d => d.IdGenreNavigation)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_movies_id_genre");
            });

            modelBuilder.Entity<AccountMovies>(entity =>
            {
                entity.HasNoKey();
                entity.ToTable("AccountsMovies");
                entity.Property(e => e.AccountId).HasColumnName("account_id");
                entity.Property(e => e.MovieId).HasColumnName("movie_id");
                
                entity.HasOne(d => d.Account)
                    .WithMany()
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_accountsmovies_account");

                entity.HasOne(d => d.Movie)
                   .WithMany()
                   .HasForeignKey(d => d.MovieId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("fk_accountsmovies_movie");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
