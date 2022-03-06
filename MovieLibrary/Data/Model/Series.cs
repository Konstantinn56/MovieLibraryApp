using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// Series Entity
    /// </summary>
    public class Series
    {
        /// <summary>
        /// The id of the person who add a series
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the added series
        /// </summary>
        public string SeriesTitle { get; set; }

        /// <summary>
        /// The number of the season of the series
        /// </summary>
        public int Seasons { get; set; }

        /// <summary>
        /// The year when the first season comes out
        /// </summary>
        public int SeriesYaer { get; set; }

        /// <summary>
        /// The type of the series
        /// </summary>
        public string SeriesType { get; set; }

        /// <summary>
        /// User evaluation for the series
        /// </summary>
        public int StarsForSeries { get; set; }

        /// <summary>
        /// The rating of the series
        /// </summary>
        public double RateForSeries { get; set; }
    }
}
