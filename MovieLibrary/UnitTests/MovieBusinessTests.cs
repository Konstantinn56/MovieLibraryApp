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
            movieBusiness = new MovieBusiness();
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
                Title = "Encanto",
                Genre = "Animation"
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
        /// Test for method Delete when the Movie exist
        /// </summary>
        [TestMethod]
        public void DeleteMovie_ExistingMovie_RemovesMovie()
        {
            Movie movie = new Movie()
            {
                MId = 1,
                Title = "Spider-Man No way Home"
            };

            ///Act
            var movieDb = movieBusiness.Get(movie.MId);
            movieBusiness.Delete(movie.MId);

            ///Assert
            Assert.AreEqual(movie.Title, movieDb.Title);
        }

        /// <summary>
        /// Test for method Delete when the movie doesn't exist
        /// </summary>
        [TestMethod]
        public void DeleteMovie_NotExistingMovie_ThrowArgumentException()
        {
            ///Arrange
            Movie movie = new Movie()
            {
                MId = 100
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => movieBusiness.Delete(movie.MId));
            Assert.AreEqual("This movie doesn't exist!", exception.Message);

        }

        /// <summary>
        /// Test for method Update when the Movie exist
        /// </summary>
        [TestMethod]
        public void UpdateMovie_ExistingMovie_ReturnsUpdatedMovie()
        {
            ///Arrange
            Movie movie = new Movie()
            {
                MId = 2,
                Title = "Encanto",
                Genre = "Animation, Family"
            };

            ///Act
            var movieDb = movieBusiness.Get(movie.MId);
            movieBusiness.Update(movie);

            ///Assert
            Assert.AreNotEqual(movie.Genre, movieDb.Genre);
        }

        /// <summary>
        /// Test for method Update when the movie doesn't exist
        /// </summary>
        [TestMethod]
        public void UpdateMovie_NotExistingMovie_ThrowArgumentException()
        {
            ///Arrange
            Movie movie = new Movie()
            {
                Title = "1917",
                Genre = "War"
            };

            ///Act and Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => movieBusiness.Update(movie));
            Assert.AreEqual("This movie doesn't exist!", exception.Message);
        }
    }
}
