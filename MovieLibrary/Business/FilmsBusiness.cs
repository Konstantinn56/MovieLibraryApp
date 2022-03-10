using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business

{   /// <summary>
    /// Business Logic of the Film
    /// </summary>
    public class FilmsBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get a film from the database by Id
        /// </summary>
        public Movie Get(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Films.Find(id);
            }
        }

        /// <summary>
        /// Add a film to the database
        /// </summary>
        public void Add(Movie film)
        {
            using (applicationContext = new ApplicationContext())
            {
                applicationContext.Films.Add(film);
                applicationContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a film in the database by Id.
        /// </summary>
        public void Update(Movie film)
        {
            using (applicationContext = new ApplicationContext())
            {
                var item = applicationContext.Films.Find(film.Id);
                if (item != null)
                {
                    applicationContext.Entry(item).CurrentValues.SetValues(film);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a film from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                var film = applicationContext.Films.Find(id);
                if (film != null)
                {
                    applicationContext.Films.Remove(film);
                    applicationContext.SaveChanges();
                }
            }
        }
    }
}
