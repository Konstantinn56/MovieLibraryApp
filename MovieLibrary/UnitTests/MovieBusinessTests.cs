using Business;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    /// <summary>
    /// Test for MovieBusiness
    /// </summary>
    [TestClass]
    public class MovieBusinessTests
    {
        private MovieBusiness movieBusiness;

        public MovieBusinessTests()
        {
            var movieBusiness = new MovieBusiness();
        }

        /// <summary>
        /// Test for method Get
        /// </summary>
        [TestMethod]
        public void GetMovie()
        {

        }

        /// <summary>
        /// Test for method Add when the movie doesn't existing
        /// </summary>
        [TestMethod]
        public void AddMovie_NotExistingMovie_ReturnsMovie()
        {
            ///Arrange
            Movie movie = new Movie()
            {
                MId = 2,
                Title = "Encanto"
            };

            ///Act
            movieBusiness.Add(movie);
            var movieDb = movieBusiness.Get(movie.MId);

            ///Assert
            Assert.AreEqual(movie.MId, movieDb.MId);
        }

        /// <summary>
        /// Test for method Add when the movie exist
        /// </summary>
        [TestMethod]
        public void AddMovie_ExistingMovie_ThrowArgumentException()
        {
            ///Arrange
            Movie movie = new Movie()
            {
                Title = "Spider-Man No way Home"
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => movieBusiness.Add(movie));
            Assert.AreEqual("This movie already exist!", exception.Message);
        }

        /// <summary>
        /// Test for method Delete
        /// </summary>
        [TestMethod]
        public void DeleteMovie()
        {

        }

        /// <summary>
        /// Test for method Update
        /// </summary>
        [TestMethod]
        public void UodateMovie()
        {

        }
    }
}
