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
