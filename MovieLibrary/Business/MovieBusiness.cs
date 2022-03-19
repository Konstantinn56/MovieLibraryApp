using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business

{   /// <summary>
    /// Business Logic of the Movie
    /// </summary>
    public class MovieBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get a Movie from the database by Id
        /// </summary>
        public Movie Get(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Movies.Find(id);
            }
        }

        /// <summary>
        /// Get a Movie from the database by Title
        /// </summary>
        public Movie GetByTitle(string title)
        {
            using (applicationContext = new ApplicationContext())
            {
                Movie movie = applicationContext.Movies.Where(m => m.Title.ToLower().Equals(title.ToLower())).FirstOrDefault();
                if(movie == null)
                {
                    throw new ArgumentException("This movie does not exists!");
                }
                else
                {
                    return movie;
                }
            }
        }

        /// <summary>
        /// Get all Movies from the database
        /// </summary>
        public List<Movie> GetAll()
        {
            using (applicationContext = new ApplicationContext())
            {
                List<Movie> movieList = new List<Movie>();
                foreach (Movie m in applicationContext.Movies)
                {
                    movieList.Add(m);
                }
                return movieList;
            }
        }

        /// <summary>
        /// Add a Movie to the database
        /// </summary>
        public void Add(Movie movie)
        {
            using (applicationContext = new ApplicationContext())
            {
                var movieDb = applicationContext.Movies.FirstOrDefault(m => m.Title == movie.Title);

                if (movieDb != null)
                {
                    throw new ArgumentException("This movie already exist!");
                }
                else
                {
                    applicationContext.Movies.Add(movie);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a Movie in the database by Id.
        /// </summary>
        public void Update(Movie movie)
        {
            using (applicationContext = new ApplicationContext())
            {
                var item = applicationContext.Movies.Find(movie.MId);
                if (item != null)
                {
                    applicationContext.Entry(item).CurrentValues.SetValues(movie);
                    applicationContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("This movie doesn't exist!");
                }
            }
        }

        /// <summary>
        /// Delete a Movie from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                var film = applicationContext.Movies.Find(id);
                if (film != null)
                {
                    applicationContext.Movies.Remove(film);
                    applicationContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("This movie doesn't exist!");
                }
            }
        }
    }
}
