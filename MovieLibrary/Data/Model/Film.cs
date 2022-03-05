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
    public class Film
    {
        /// <summary>
        /// The id of the person who add a film
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the added film
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The publisher of the film
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// The year the film comes out
        /// </summary>
        public int FilmYaer { get; set; }

        /// <summary>
        /// The type of the film
        /// </summary>
        public string FilmType { get; set; }

        /// <summary>
        /// User evaluation for the film
        /// </summary>
        public int Stars { get; set; }

        /// <summary>
        /// The rating of the film 
        /// </summary>
        public double Rate { get; set; }
    }
}
