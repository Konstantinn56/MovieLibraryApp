using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Film Entity
/// </summary>
namespace Data.Model
{
    public partial class Movie
    {
        /// <summary>
        /// The id of the person who add a film
        /// </summary>
        [Key]
        public int MId { get; set; }

        /// <summary>
        /// Image of the movie
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// The name of the added film
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// The type of the film
        /// </summary>
        public string Genre { get; set; } = null!;

        /// <summary>
        /// The year the film comes out
        /// </summary>
        public int YaerOfCreation { get; set; }
        
        /// <summary>
        /// The rating of the film 
        /// </summary>
        public double Rate { get; set; }
    }
}
