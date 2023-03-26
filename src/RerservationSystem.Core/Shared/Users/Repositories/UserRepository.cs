using RerservationSystem.Core.Shared.Data;
using RerservationSystem.Core.Shared.Users.Entities;

namespace RerservationSystem.Core.Shared.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlService _sqlService;

        public UserRepository(ISqlService sqlService)
        {
            _sqlService = sqlService;
        }

        public async Task<int> CreateUserAsync(User user)
        {
            var affectedRows = await _sqlService
                .CreateAsync<User>(UserRepositorySql.CreateUserQuery,
                    new
                    {
                        userRole = (int)user.UserRole,
                        document = user.Document,
                        email = user.Email,
                        password = user.Password,
                        dateInsertion = user.DateInsertion,
                        dateAlteration = user.DateAlteration
                    });

            return affectedRows;
        }
    }
}
