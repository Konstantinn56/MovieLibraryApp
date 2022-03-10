using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business logic of FavouriteMovies
    /// </summary>
    public class FavouriteMoviesBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get single movie from the database by Title
        /// </summary>
        public Movie Get(string title)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Movies.Find(title);
            }
        }

        /// <summary>
        /// Add a movie to the database
        /// </summary>
        public void Add(Movie movie)
        {
            using (applicationContext = new ApplicationContext())
            {
                applicationContext.Movies.Add(movie);
                applicationContext.SaveChanges();
            }
        }

        /// <summary>
        /// Delete movie from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            var movie = applicationContext.Movies.Find(id);
            using (applicationContext = new ApplicationContext())
            {
                if (movie != null)
                {
                    applicationContext.Movies.Remove(movie);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a movie in the database
        /// </summary>
        public void Update(Movie movie)
        {
            using (applicationContext = new ApplicationContext())
            {
                Movie currentMovie = applicationContext.Movies.Find(movie.Id);
                if (currentMovie != null)
                {
                    applicationContext.Entry(currentMovie).CurrentValues.SetValues(movie);
                }
            }
        }
    }
}
