using Microsoft.EntityFrameworkCore;
using Data.Model;

namespace Data
{
    /// <summary>
    /// Account Database Context
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Accounts Table
        /// </summary>
        public virtual DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Movies Table
        /// </summary>
        public virtual DbSet<Movie> Movies { get; set; }

        /// <summary>
        /// Series Table
        /// </summary>
        public virtual DbSet<Series> Series { get; set; }

        /// <summary>
        /// Favourite Movies Table
        /// </summary>
        public virtual DbSet<FavouriteMovies> FavMovies { get; set; }

        /// <summary>
        /// Favourite Series Table
        /// </summary>
        public virtual DbSet<FavouriteSeries> FavSeries { get; set; }

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
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MLibraryDB;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
