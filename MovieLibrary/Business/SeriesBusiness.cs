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
    }
}
