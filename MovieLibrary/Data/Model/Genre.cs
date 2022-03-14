using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public partial class Genre
    {
        /// <summary>
        /// The id of the genre
        /// </summary>
        [Key]
        public int GId { get; set; }

        /// <summary>
        /// The name of the genre
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
