using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    /// <summary>
    /// Genre Entity
    /// </summary>
    public partial class Genre
    {
        /// <summary>
        /// The id of the Genre
        /// </summary>
        [Key]
        public int GId { get; set; }

        /// <summary>
        /// The name of the Genre
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
