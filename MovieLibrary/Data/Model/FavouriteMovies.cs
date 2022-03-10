using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FavouriteMovies Entity
/// </summary>
namespace Data.Model
{
    public class FavouriteMovies
    {
        /// <summary>
        /// Account id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Movie id
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Information from class account
        /// </summary>
        public virtual Account Account { get; set; } = null!;

        /// <summary>
        /// Information from class Films
        /// </summary>
        public virtual Movie Movie { get; set; } = null!;
    }
}
