using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Movie Entity
/// </summary>
namespace Data.Model
{
    public partial class Movie
    {
        /// <summary>
        /// The id of the person who add/update/delete/get the movie
        /// </summary>
        [Key]
        public int MId { get; set; }

        /// <summary>
        /// Image of the Movie
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// The name of the added film
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// The type of the Movie
        /// </summary>
        public string Genre { get; set; } = null!;

        /// <summary>
        /// The type of the Movie
        /// </summary>
        public string Genre2 { get; set; } = null!;

        /// <summary>
        /// The type of the Movie
        /// </summary>
        public string Genre3 { get; set; } = null!;

        /// <summary>
        /// The year when the Movie comes out
        /// </summary>
        public int YaerOfCreation { get; set; }
        
        /// <summary>
        /// The rating of the Movie
        /// </summary>
        public double Rate { get; set; }
    }
}
