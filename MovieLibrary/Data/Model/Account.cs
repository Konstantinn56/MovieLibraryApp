using System.ComponentModel.DataAnnotations;

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
        [Key]
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
        /// Account Username
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Account Password
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Account Reset Key
        /// </summary>
        public int RecoveryKey { get; set; }
    }
}
