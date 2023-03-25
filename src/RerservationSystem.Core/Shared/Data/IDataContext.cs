using System.Data;

namespace RerservationSystem.Core.Shared.Data
{
    public interface IDataContext
    {
        public IDbConnection GetConnection();
    }
}
