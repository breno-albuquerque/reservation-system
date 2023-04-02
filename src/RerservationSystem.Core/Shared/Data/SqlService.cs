using Dapper;

namespace RerservationSystem.Core.Shared.Data
{
    public sealed class SqlService : ISqlService
    {
        private readonly IDataContext _context;

        public SqlService(IDataContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync<T>(string sql, object param)
        {
            using (var connection = _context.GetConnection())
                return await connection.ExecuteAsync(sql, param);
        }

        public async Task<bool> ExistsAsync(string sql, object param)
        {
            using (var connection = _context.GetConnection())
                return await connection.ExecuteScalarAsync<bool>(sql, param);
        }

        public async Task<T> GetAsync<T>(string sql, object param)
        {
            using (var connection = _context.GetConnection())
                return await connection.QueryFirstOrDefaultAsync<T>(sql, param);
        }

        public async Task<IEnumerable<T>> ListAsync<T>(string sql, object param)
        {
            using (var connection = _context.GetConnection())
                return await connection.QueryAsync<T>(sql, param);
        }
    }
}
