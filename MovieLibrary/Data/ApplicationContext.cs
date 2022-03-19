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
                    new Movie {MId = 1,Title = "Gladiator", Genre = "Action",Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.Gladiator ,YaerOfCreation = 2000, Rate = 8.5},
                    new Movie {MId = 2, Title = "The Matrix", Genre = "Action", Genre2 = "Sci-Fi", Genre3 = "", Image = Properties.Resources.The_Matrix, YaerOfCreation = 1999, Rate = 8.7},
                    new Movie {MId = 3, Title = "Inception", Genre = "Action", Genre2 = "Adventure", Genre3 = "Sci-Fi", Image = Properties.Resources.Inception, YaerOfCreation = 2010, Rate = 8.8},
                    new Movie {MId = 4, Title = "The Silence of the Lambs", Genre = "Crime", Genre2 = "Drama", Genre3 = "Thriller", Image = Properties.Resources.The_Silence_of_the_Lambs, YaerOfCreation = 1991, Rate = 8.6 },
                    new Movie {MId = 5, Title = "The Prestige", Genre = "Drama", Genre2 = "Mystery", Genre3 = "Thriller", Image = Properties.Resources.The_Prestige, YaerOfCreation = 2006, Rate =  8.6},
                    new Movie {MId = 6, Title = "Joker", Genre = "Crime", Genre2 = "Drama", Genre3 = "Thriller", Image = Properties.Resources.Joker, YaerOfCreation = 2009, Rate =  8.4},
                    new Movie {MId = 7, Title = "The Grand Budapest Hotel", Genre = "Adventure", Genre2 = "Comedy", Genre3 = "Crime", Image = Properties.Resources.The_Grand_Budapest_Hotel, YaerOfCreation = 2014, Rate =  8.1},
                    new Movie {MId = 8, Title = "The Lord Of the Rings: The Fellowship of the Ring", Genre = "Action", Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.The_Lord_of_the_Rings_The_Fellowship_of_the_Ring, YaerOfCreation = 2001, Rate =  8.9},
                    new Movie {MId = 9, Title = "The Lord Of the Rings: The Two Towers", Genre = "Action", Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.The_Lord_of_the_Rings_The_Two_Towers, YaerOfCreation = 2002, Rate =  8.8},
                    new Movie {MId = 10, Title = "The Lord Of the Rings: The Return of the King", Genre = "Action", Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.The_Lord_of_the_Rings_The_Return_of_the_King, YaerOfCreation = 2003, Rate =  9},
                    new Movie {MId = 11, Title = "Spirited away", Genre = "Anime", Genre2 = "Adventure", Genre3 = "Family", Image = Properties.Resources.Spirited_away, YaerOfCreation = 2001, Rate = 8.6 },
                    new Movie {MId = 12, Title = "Your name", Genre = "Anime", Genre2 = "Drama", Genre3 = "Fantasy", Image = Properties.Resources.Your_name, YaerOfCreation =2016 , Rate = 8.4 },
                    new Movie {MId = 13, Title = "Princess Mononoke", Genre = "Anime", Genre2 = "Action", Genre3 = "Adventure", Image = Properties.Resources.Princess_Mononoke, YaerOfCreation = 1997, Rate = 8.4 },
                    new Movie {MId = 14, Title = "Demon Slayer Mugen Train", Genre = "Anime", Genre2 = "Action", Genre3 = "Adventure", Image = Properties.Resources.Demon_Slayer_Mugen_Train, YaerOfCreation = 2020, Rate = 8.3 },
                    new Movie {MId = 15, Title = "Lion King", Genre = "Animation", Genre2 = "Adventure", Genre3 = "Drama", Image = Properties.Resources.Lion_King, YaerOfCreation = 1994, Rate = 8.5 },
                    new Movie {MId = 16, Title = "Coco", Genre = "Animation", Genre2 = "Adventure", Genre3 = "Comedy", Image = Properties.Resources.Coco, YaerOfCreation = 2017, Rate = 8.4 },
                    new Movie {MId = 17, Title = "Aladdin", Genre = "Animation", Genre2 = "Adventure", Genre3 = "Comedy", Image = Properties.Resources.Aladdin, YaerOfCreation = 1992, Rate = 8.1 },
                    new Movie {MId = 18, Title = "Beauty and the Beast", Genre = "Animation", Genre2 = "Family", Genre3 = "Fantasy", Image = Properties.Resources.Beauty_and_the_Beast, YaerOfCreation = 1991, Rate = 8.1 },
                    new Movie {MId = 19, Title = "Schindler's List", Genre = "Biography", Genre2 = "Drama", Genre3 = "History", Image = Properties.Resources.Schindler_s_List, YaerOfCreation =1993 , Rate = 9.0 },
                    new Movie {MId = 20, Title = "Intouchables", Genre = "Biography", Genre2 = "Comedy", Genre3 = "Drama", Image = Properties.Resources.Intouchables, YaerOfCreation =2011 , Rate = 8.5 }
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
