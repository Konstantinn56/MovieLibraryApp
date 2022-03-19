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
            // Create the database automatically
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

        /// <summary>
        /// The structure and the information in the Tables
        /// </summary>
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
                    new Movie {MId = 20, Title = "Intouchables", Genre = "Biography", Genre2 = "Comedy", Genre3 = "Drama", Image = Properties.Resources.Intouchables, YaerOfCreation =2011 , Rate = 8.5 },
                    new Movie { MId = 21, Title = "Green Book", Genre = "Biography", Genre2 = "Comedy", Genre3 = "Drama", Image = Properties.Resources.Green_Book, YaerOfCreation = 2018, Rate =  8.2},
                    new Movie { MId = 22, Title = "A Beautiful Mind", Genre = "Biography", Genre2 = "Drama", Genre3 = "", Image = Properties.Resources.A_Beautiful_Mind, YaerOfCreation = 2001, Rate = 8.1 },
                    new Movie { MId = 23, Title = "Forest Gump", Genre = "Drama", Genre2 = "Romance", Genre3 = "", Image = Properties.Resources.Forrest_Gump, YaerOfCreation = 1994, Rate = 8.8 },
                    new Movie { MId = 24, Title = "Titanic", Genre = "Drama", Genre2 = "Romance", Genre3 = "", Image = Properties.Resources.Titanic, YaerOfCreation = 1997, Rate = 7.9 },
                    new Movie { MId = 25, Title = "The Notebook", Genre = "Drama", Genre2 = "Romance", Genre3 = "", Image = Properties.Resources.The_Notebook, YaerOfCreation = 2004, Rate = 7.8 },
                    new Movie { MId = 26, Title = "The Green Mile", Genre = "Crime", Genre2 = "Drama", Genre3 = "Fantasy", Image = Properties.Resources.The_Green_Mile, YaerOfCreation = 1999, Rate = 8.6 },
                    new Movie { MId = 27, Title = "La La Land", Genre = "Comedy", Genre2 = "Drama", Genre3 = "Music", Image = Properties.Resources.La_La_Land, YaerOfCreation = 2016, Rate = 8.0 },
                    new Movie { MId = 28, Title = "The Pianist", Genre = "Biography", Genre2 = "Drama", Genre3 = "Music", Image = Properties.Resources.The_Pianist, YaerOfCreation = 2002, Rate =  8.6},
                    new Movie { MId = 29, Title = "Whiplash", Genre = "Drama", Genre2 = "Music", Genre3 = "", Image = Properties.Resources.Whiplash, YaerOfCreation =2014 , Rate = 8.5 },
                    new Movie { MId = 30, Title = "Alien", Genre = "Horror", Genre2 = "Sci-Fi", Genre3 = "", Image = Properties.Resources.Alien, YaerOfCreation = 1979, Rate = 8.5 },
                    new Movie { MId = 31, Title = "Nosferatu", Genre = "Fantasy", Genre2 = "Horror", Genre3 = "", Image = Properties.Resources.Nosferatu, YaerOfCreation = 1922, Rate = 7.2 },
                    new Movie { MId = 32, Title = "The Conjuring", Genre = "Horror", Genre2 = "Mystery", Genre3 = "Thriller", Image = Properties.Resources.The_Conjuring, YaerOfCreation =2013 , Rate =  7.5},
                    new Movie { MId = 33, Title = "The Godfather", Genre = "Crime", Genre2 = "Drama", Genre3 = "", Image = Properties.Resources.The_Godfather, YaerOfCreation =1972 , Rate = 9.2 },
                    new Movie { MId = 34, Title = "The Shawschank Redemption", Genre = "Drama", Genre2 = "", Genre3 = "", Image = Properties.Resources.The_Shawshank_Redemption, YaerOfCreation =2013 , Rate = 7.5 },
                    new Movie { MId = 35, Title = "Pirates of the Caribbean: The Curse of the Black Pearl", Genre = "Action", Genre2 = "Adventure", Genre3 = "Fantasy", Image = Properties.Resources.Pirates_of_the_Caribbean_The_Curse_of_the_Black_Pearl, YaerOfCreation = 2003, Rate = 8.1 },
                    new Movie { MId = 36, Title = "Encanto", Genre = "Animation", Genre2 = "Comedy", Genre3 = "Family", Image = Properties.Resources.Encanto, YaerOfCreation = 2021, Rate = 7.3 },
                    new Movie { MId = 37, Title = "Taken", Genre = "Action", Genre2 = "Crime", Genre3 = "Triller", Image = Properties.Resources.Taken, YaerOfCreation = 2008 , Rate = 7.8 },
                    new Movie { MId = 38, Title = "Rush Hour", Genre = "Action", Genre2 = "Comedy", Genre3 = "Crime", Image = Properties.Resources.Rush_Hour, YaerOfCreation = 1998, Rate = 7.0 },
                    new Movie { MId = 39, Title = "Harry Potter and the Sorcerer's Stone", Genre = "Adventure", Genre2 = "Fantasy", Genre3 = "Family", Image = Properties.Resources.Harry_Potter_and_the_Sorcerer_s_Stone, YaerOfCreation = 2001, Rate = 7.6 },
                    new Movie { MId = 40, Title = "Home Alone", Genre = "Comedy", Genre2 = "Family", Genre3 = "", Image = Properties.Resources.Home_Alone, YaerOfCreation = 1990, Rate = 7.7 },
                    new Movie { MId = 41, Title = "Dumb and Dumber", Genre = "Comedy", Genre2 = "", Genre3 = "", Image = Properties.Resources.Dumb_and_Dumber, YaerOfCreation =1994 , Rate = 7.3 },
                    new Movie { MId = 42, Title = "RED", Genre = "Action", Genre2 = "Comedy", Genre3 = "Crime", Image = Properties.Resources.RED, YaerOfCreation = 2010, Rate = 7.0 },
                    new Movie { MId = 43, Title = "Ocean's Eleven", Genre = "Crime", Genre2 = "Thriller", Genre3 = "", Image = Properties.Resources.Ocean_s_Eleven, YaerOfCreation = 2001, Rate = 7.7 },
                    new Movie { MId = 44, Title = "The Italian Job", Genre = "Action", Genre2 = "Crime", Genre3 = "Thriller", Image = Properties.Resources.The_Italian_Job, YaerOfCreation = 2003 , Rate = 7.0 },
                    new Movie { MId = 45, Title = "National Treasure", Genre = "Action", Genre2 = "Adventure", Genre3 = "Mystery", Image = Properties.Resources.National_Treasure, YaerOfCreation = 2004 , Rate = 6.9 }
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
