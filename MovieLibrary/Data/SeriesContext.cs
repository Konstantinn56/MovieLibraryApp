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
    /// Film Database Context
    /// </summary>
    public class SeriesContext : DbContext
    {
        /// <summary>
        /// Films Table
        /// </summary>
        public DbSet<Series> Series { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public SeriesContext()
        {
            //Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        public SeriesContext(DbContextOptions<SeriesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MLibraryDB; Integrated Security = True;:";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
