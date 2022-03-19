using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    /// <summary>
    /// class AccountMovies
    /// </summary>
    public partial class AccountMovies
    {
        /// <summary>
        /// Id
        /// </summary>
        ///
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The account id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// The Movie Id
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// The current status of the Movie
        /// </summary>
        public string State { get; set; } = null!;

        /// <summary>
        /// Information from class Account
        /// </summary>
        public virtual Account Account { get; set; } = null!;

        /// <summary>
        /// Information from class movie
        /// </summary>
        public virtual Movie Movie { get; set; } = null!;
    }
}
