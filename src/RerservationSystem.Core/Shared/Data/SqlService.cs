﻿using Dapper;

namespace RerservationSystem.Core.Shared.Data
{
    public sealed class SqlService : ISqlService
    {
        private readonly IDataContext _context;

        public SqlService(IDataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> ListAsync<T>(string sql, object param)
        {
            using (var connection = _context.GetConnection())
                return await connection.QueryAsync<T>(sql, param);
        }
    }
}