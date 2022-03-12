using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// class AccountMovies
    /// </summary>
    public partial class AccountMovies
    {
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
        /// Information from class account
        /// </summary>
        public virtual Account Account { get; set; } = null!;

        /// <summary>
        /// information from class movie
        /// </summary>
        public virtual Movie Movie { get; set; } = null!;

    }
}
