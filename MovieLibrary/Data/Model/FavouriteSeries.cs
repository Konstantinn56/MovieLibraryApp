using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FavouriteSeries Entity
/// </summary>
namespace Data.Model
{
    public class FavouriteSeries
    {
        /// <summary>
        /// Account id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// Favourite series Id
        /// </summary>
        public int SeriesId { get; set; }
    }
}
