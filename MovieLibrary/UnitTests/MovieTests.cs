using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    /// <summary>
    /// Test for Movie
    /// </summary>
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void Movie()
        {
            Movie movie = new Movie();
            movie.Title = "Spirited away";
            movie.Genre = "Anime, Adventure, Family";
            movie.YaerOfCreation = 2001;
            movie.Rate = 8.6;

            Assert.AreNotEqual(movie.Title, movie.Genre);
        }
    }
}
