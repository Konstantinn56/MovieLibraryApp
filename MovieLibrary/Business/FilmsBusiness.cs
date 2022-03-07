using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    public class FilmsBusiness
    {
        private FilmContext filmContext = new FilmContext();

        public Film FilmGet(int id)
        {
            using (filmContext = new FilmContext())
            {
                return filmContext.Films.Find(id);
            }
        }

        public void FilmAdd(Film film)
        {
            using (filmContext = new FilmContext())
            {
                filmContext.Films.Add(film);
                filmContext.SaveChanges();
            }
        }

        public void FilmUpdate(Film film)
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

        public void FilmDelete(int id)
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
