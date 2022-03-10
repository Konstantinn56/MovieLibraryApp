using Microsoft.EntityFrameworkCore;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Films Table
        /// </summary>
        public DbSet<Movie> Films { get; set; }

        /// <summary>
        /// Series Table
        /// </summary>
        public DbSet<Series> Series { get; set; }


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
