using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GenreTests
    {
        [TestMethod]
        public void Genre()
        {
            Genre genre = new Genre();
            genre.Name = "Animation";

            Assert.IsNotNull(genre);

        }
    }
}
