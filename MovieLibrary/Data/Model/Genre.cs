using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    /// <summary>
    /// class Genre
    /// </summary>
    public partial class Genre
    {
        /// <summary>
        /// Initializes a new instance of the Genre class.
        /// </summary>
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        /// <summary>
        /// Genre id
        /// </summary>
        [Key]
        public int GId { get; set; }

        /// <summary>
        /// Name of the genre
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of Movies.
        /// </summary>
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
