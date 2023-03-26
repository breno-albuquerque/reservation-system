namespace RerservationSystem.Core.Shared.Data
{
    public interface ISqlService
    {
        Task<int> CreateAsync<T>(string sql, object param);

        Task<IEnumerable<T>> ListAsync<T>(string sql, object param);

        Task<bool> ExistsAsync(string sql, object param);
    }
}
