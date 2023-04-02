using RerservationSystem.Core.Shared.Users.Entities;

namespace RerservationSystem.Core.Shared.Users.Repositories
{
    public interface IUserRepository
    {
        Task<int> CreateUserAsync(User user);

        Task<bool> ExistsAsync(string email);

        Task<User> GetAsync(string email);
    }
}
