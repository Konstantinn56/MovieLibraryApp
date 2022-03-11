using System;
using System.Collections.Generic;
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
        public int MId { get; set; }

        /// <summary>
        /// The name of the added film
        /// </summary>
        public string Title { get; set; } = null!;

        /// <summary>
        /// The current status of the Movie
        /// </summary>
        public string State { get; set; } = null!;

        /// <summary>
        /// The type of the film
        /// </summary>
        public int GenreId { get; set; }

        /// <summary>
        /// Image of the movie
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// The publisher of the film
        /// </summary>
        public string Publisher { get; set; } = null!;

        /// <summary>
        /// The year the film comes out
        /// </summary>
        public int YaerOfCreation { get; set; }
        
        /// <summary>
        /// User evaluation for the film
        /// </summary>
        public int Stars { get; set; }

        /// <summary>
        /// The rating of the film 
        /// </summary>
        public float Rate { get; set; }

        /// <summary>
        /// The identifier genre navigation
        /// </summary>
        public virtual Genre IdGenreNavigation { get; set; } = null!;
    }
}
