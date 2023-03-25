using Microsoft.Data.SqlClient;
using System.Data;

namespace RerservationSystem.Core.Shared.Data
{
    public sealed class DataContext : IDataContext
    {
        private const string ConnectionString = @"
            Server=localhost,1433;
            Database=SQL_RESERVATION_SYSTEM;
            User ID=sa;Password=1q2w3e4r@#$;
            Trusted_Connection=False; 
            TrustServerCertificate=True;";

        public IDbConnection GetConnection() =>
            new SqlConnection(ConnectionString);
    }
}
