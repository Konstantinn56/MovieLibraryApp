using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the FavouriteSeries
    /// </summary>
    public class FavouriteSeriesBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Get single series from the database by Title
        /// </summary>
        public Series Get(string title)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Series.Find(title);
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
        /// Delete series from the database by Id
        /// </summary>
        public void Delete(int id)
        {
            var series = applicationContext.Series.Find(id);
            using (applicationContext = new ApplicationContext())
            {
                if(series != null)
                {
                    applicationContext.Series.Remove(series);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Update a series in the database
        /// </summary>
        public void Update (Series series)
        {
            using (applicationContext = new ApplicationContext())
            {
                Series currentSeries = applicationContext.Series.Find(series.Id);
                if(currentSeries != null)
                {
                    applicationContext.Entry(currentSeries).CurrentValues.SetValues(series);
                }
            }
        }
    }
}
