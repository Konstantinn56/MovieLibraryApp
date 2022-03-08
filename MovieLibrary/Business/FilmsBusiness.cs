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
        private FilmContext filmContext = new FilmContext();

        /// <summary>
        /// Get a film from the database by Id
        /// </summary>
        public Film Get(int id)
        {
            using (filmContext = new FilmContext())
            {
                return filmContext.Films.Find(id);
            }
        }

        /// <summary>
        /// Add a film to the database
        /// </summary>
        public void Add(Film film)
        {
            using (filmContext = new FilmContext())
            {
                filmContext.Films.Add(film);
                filmContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a film in the database by Id.
        /// </summary>
        public void Update(Film film)
        {
            using (filmContext = new FilmContext())
            {
                var item = filmContext.Films.Find(film.Id);
                if (item != null)
                {
                    filmContext.Entry(item).CurrentValues.SetValues(film);
                    filmContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a film from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (filmContext = new FilmContext())
            {
                var film = filmContext.Films.Find(id);
                if (film != null)
                {
                    filmContext.Films.Remove(film);
                    filmContext.SaveChanges();
                }
            }
        }
    }
}
