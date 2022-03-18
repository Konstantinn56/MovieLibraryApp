using Microsoft.EntityFrameworkCore;
using Data.Model;
using Data;

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
        /// Movies Table
        /// </summary>
        public virtual DbSet<Movie> Movies { get; set; } 

        /// <summary>
        /// Genres Table
        /// </summary>
        public virtual DbSet<Genre> Genres { get; set; } = null!;

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
            //fluent api
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
                    new Account {AId = 1, FirstName = "Konstatnin", LastName = "Balabanov", Username = "admin", Password = "admin", RecoveryKey = 100000 },
                    new Account {AId = 2, FirstName = "Velina", LastName = "Yordanova", Username = "admin_2", Password = "admin_2", RecoveryKey = 100001 },
                    new Account {AId = 3, FirstName = "Dimitar", LastName = "Stoyanov", Username = "dimSt", Password = "1234", RecoveryKey = 100002 }
                );
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GId)
                    .HasName("pk_genres_id");

                entity.Property(e => e.GId)
                    .UseIdentityColumn()
                    .HasColumnName("id_genre");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasData
                (
                    new Genre{GId = 1, Name = "Add New Genre"},
                    new Genre{GId = 2, Name = "Action"},  
                    new Genre{GId = 3, Name = "Adventure"},  
                    new Genre{GId = 4, Name = "Drama"}, 
                    new Genre{GId = 5, Name = "Sci-Fi"},  
                    new Genre{GId = 6, Name = "Crime"}, 
                    new Genre{GId = 7, Name = "Thriller"},  
                    new Genre{GId = 8, Name = "Comedy"},     
                    new Genre{GId = 9, Name = "Fantasy"},
                    new Genre{GId = 10, Name = "Mystery"},
                    new Genre{GId = 11, Name = "Family"},
                    new Genre{GId = 12, Name = "History"},
                    new Genre{GId = 13, Name = "Biography"},
                    new Genre{GId = 14, Name = "Horror"},
                    new Genre{GId = 15, Name = "Music"},
                    new Genre{GId = 16, Name = "Romance"}
                );
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MId)
                    .HasName("pk_movies_id");

                entity.Property(e => e.MId).HasColumnName("id_movie");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Genre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Genre");

                entity.Property(e => e.Genre2)
                   .HasMaxLength(255)
                   .IsUnicode(false)
                   .HasColumnName("Genre2");

                entity.Property(e => e.Genre3)
                   .HasMaxLength(255)
                   .IsUnicode(false)
                   .HasColumnName("Genre3");

                entity.Property(e => e.YaerOfCreation).HasColumnName("year");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.HasData
                (
                    new Movie {MId = 1,Title = "Gladiator", Genre = "Action",Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.Gladiator ,YaerOfCreation = 2000, Rate = 8.5}
                    
                );
            });

            modelBuilder.Entity<AccountMovies>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("pk_accountMovies_id");

                entity.Property(e => e.Id)
                    .UseIdentityColumn()
                    .HasColumnName("accountMovies_id");

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
                
                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
