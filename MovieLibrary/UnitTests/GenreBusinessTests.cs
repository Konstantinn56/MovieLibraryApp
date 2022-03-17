using Business;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    /// <summary>
    /// Test for GenreBusiness
    /// </summary>
    [TestClass]
    public class GenreBusinessTests
    {
        private GenreBusiness genreBusiness;

        public GenreBusinessTests()
        {
            genreBusiness = new GenreBusiness();
        }

        /// <summary>
        /// Test for method Add when the genre doesn't existing
        /// </summary>
        [TestMethod]
        public void AddGenre_NotExistingGenre_ReturnsGenre()
        {
            ///Arrange
            Genre genre = new Genre()
            {
                Name = "Test"
            };

            ///Act
            genreBusiness.Add(genre);
            var genreDb = genreBusiness.Get(genre.Name);

            ///Assert
            Assert.AreEqual(genre.Name, genreDb.Name);
        }

        /// <summary>
        /// Test for method Add when the genre exist
        /// </summary>
        [TestMethod]
        public void AddGenre_ExistingGenre_ThrowArgumentException()
        {
            ///Arrange
            Genre genre = new Genre()
            {
                Name = "Animation"
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => genreBusiness.Add(genre));
            Assert.AreEqual("Genre already exist!", exception.Message);
        }
    }
}
