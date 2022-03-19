using Data;
using Data.Model;

namespace Business
{
    /// <summary>
    /// Business Logic of the AccountMoviesBusiness
    /// </summary>
    public class AccountMoviesBusiness
    {
        private ApplicationContext applicationContext = new ApplicationContext();

        /// <summary>
        /// Add a Movie to the database by Account and Movie
        /// </summary>
        public void Add(int aId, int mId)
        {
            using (applicationContext = new ApplicationContext())
            {
                var accountMovies = applicationContext.AccountsMovies.Where((a => (a.AccountId == aId) && (a.MovieId == mId))).FirstOrDefault();
                if(accountMovies != null)
                {
                    throw new ArgumentException("Movie already exist!");
                }
                else
                {
                    Movie movie = applicationContext.Movies.FirstOrDefault(m => m.MId == mId);
                    Account account = applicationContext.Accounts.FirstOrDefault(a => a.AId == aId);
                    AccountMovies newAccountMovies = new AccountMovies() { AccountId = aId, MovieId = mId, State = "", Account = account, Movie = movie};
                    applicationContext.AccountsMovies.Add(newAccountMovies);
                    applicationContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Delete a Movie from the Database By AccountId and MovieId
        /// </summary>
        public void Delete(int aId, int mId)
        {
            using (applicationContext = new ApplicationContext())
            {
                var accountMovies = applicationContext.AccountsMovies.FirstOrDefault((a => (a.AccountId == aId) && (a.MovieId == mId)));
                if(accountMovies == null)
                {
                    throw new ArgumentException("Movie does not exist!");
                }
                else
                {
                    applicationContext.AccountsMovies.Remove(accountMovies);
                    applicationContext.SaveChanges();
                }
            }
        }
    }
}
