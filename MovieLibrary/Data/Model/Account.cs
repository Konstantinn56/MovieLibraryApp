

namespace Data.Model
{
    /// <summary>
    /// Account Entity
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account identication
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Person FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Person LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Account password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Account Reset Key
        /// </summary>
        public int RecoveryKey { get; set; }
    }
}
