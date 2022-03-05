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
    public class FilmContext : DbContext
    {
        /// <summary>
        /// Films Table
        /// </summary>
        public DbSet<Film> Films { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FilmContext()
        {
            //Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MLibFilmsDB; Integrated Security = True;:";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
