using System.Data.SqlClient;

namespace Data
{
    /// <summary>
    /// Microsoft SQL Server DataBase Connection Class
    /// </summary>
    public static class DataBase
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MLibraryDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
