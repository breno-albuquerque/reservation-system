namespace RerservationSystem.Core.Shared.Data
{
    public interface ISqlService
    {
        Task<IEnumerable<T>> ListAsync<T>(string sql, object param);
    }
}
