using System;
using System.Collections.Generic;

namespace Data.Model
{
    /// <summary>
    /// Account Entity
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Account identication
        /// </summary>
        public int AId { get; set; }

        /// <summary>
        /// Person FirstName
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Person LastName
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Account username
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Account password
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Account Reset Key
        /// </summary>
        public int RecoveryKey { get; set; }
    }
}
