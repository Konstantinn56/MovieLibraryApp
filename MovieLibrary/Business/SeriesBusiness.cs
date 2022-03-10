using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the Series
    /// </summary>
    public class SeriesBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get a series from the database by Id
        /// </summary>
        public Series Get(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Series.Find(id);
            }
        }

        /// <summary>
        /// Add a series to the database
        /// </summary>
        public void Add(Series series)
        {
            using (applicationContext = new ApplicationContext())
            {
                applicationContext.Series.Add(series);
                applicationContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a series in the database by Id.
        /// </summary>
        public void Update(Series series)
        {
            using (applicationContext = new ApplicationContext())
            {
                var item = applicationContext.Series.Find(series.Id);
                if (item != null)
                {
                    applicationContext.Entry(item).CurrentValues.SetValues(series);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a series from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            using (applicationContext = new ApplicationContext())
            {
                var film = applicationContext.Series.Find(id);
                if (film != null)
                {
                    applicationContext.Series.Remove(film);
                    applicationContext.SaveChanges();
                }
            }
        }
    }
}
