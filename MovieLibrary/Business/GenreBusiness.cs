﻿using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the Genre
    /// </summary>
    public class GenreBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Add a genre to the database
        /// </summary>
        public void Add(Genre genre)
        {
            using (applicationContext = new ApplicationContext())
            {
                applicationContext.Genres.Add(genre);
                applicationContext.SaveChanges();
            }
        }

        /// <summary>
        /// Get single genre from the database by Name
        /// </summary>
        public Genre Get(string name)
        {
            using (applicationContext = new ApplicationContext())
            {
                return applicationContext.Genres.Where(a => a.Name.Equals(name)).FirstOrDefault();
            }
        }
    }
}
