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
        private SeriesContext seriesContext = new SeriesContext();

        /// <summary>
        /// Get a series from the database by Id
        /// </summary>
        public Series SeriesGet(int id)
        {
            using (seriesContext = new SeriesContext())
            {
                return seriesContext.Series.Find(id);
            }
        }

        /// <summary>
        /// Add a series to the database
        /// </summary>
        public void SeriesAdd(Series series)
        {
            using (seriesContext = new SeriesContext())
            {
                seriesContext.Series.Add(series);
                seriesContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a series in the database by Id.
        /// </summary>
        public void SeriesUpdate(Series series)
        {
            using (seriesContext = new SeriesContext())
            {
                var item = seriesContext.Series.Find(series.Id);
                if (item != null)
                {
                    seriesContext.Entry(item).CurrentValues.SetValues(series);
                    seriesContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deleate a series from the database by Id
        /// </summary>
        public void SeriesDelete(int id)
        {
            using (seriesContext = new SeriesContext())
            {
                var film = seriesContext.Series.Find(id);
                if (film != null)
                {
                    seriesContext.Series.Remove(film);
                    seriesContext.SaveChanges();
                }
            }
        }
    }
}
