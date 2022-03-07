using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Model;

namespace Business
{
    public class SeriesBusiness
    {
        private SeriesContext seriesContext = new SeriesContext();

        public Series SeriesGet(int id)
        {
            using (seriesContext = new SeriesContext())
            {
                return seriesContext.Series.Find(id);
            }
        }

        public void SeriesAdd(Series series)
        {
            using (seriesContext = new SeriesContext())
            {
                seriesContext.Series.Add(series);
                seriesContext.SaveChanges();
            }
        }

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
