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
                var genreDb = applicationContext.Genres.FirstOrDefault(g => g.Name == genre.Name);

                if (genreDb != null)
                {
                    throw new ArgumentException("Genre already exist!");
                }
                else
                {
                    applicationContext.Genres.Add(genre);
                    applicationContext.SaveChanges();
                }
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

        /// <summary>
        /// Get all genres and return it into List
        /// </summary>
        public List<Genre> GetAllGenres()
        {
            using (applicationContext = new ApplicationContext())
            {
                List<Genre> allGenres = new List<Genre>();

                foreach (Genre genre in applicationContext.Genres)
                {
                    allGenres.Add(genre);
                }
                return allGenres;
            }
        }
    }
}
