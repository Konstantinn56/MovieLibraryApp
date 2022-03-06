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
    public class AccountContext : DbContext
    {
        /// <summary>
        /// Accounts Table
        /// </summary>
        public DbSet<Account> Accounts { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public AccountContext()
        {
            // Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
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
