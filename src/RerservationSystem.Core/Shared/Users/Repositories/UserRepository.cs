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
            try
            {
                var affectedRows = await _sqlService
                    .CreateAsync<User>(UserRepositorySql.CreateUserQuery,
                        new
                        {
                            userRole = (int)user.UserRole,
                            document = user.Document,
                            email = user.Email,
                            passwordHash = user.PasswordHash,
                            dateInsertion = user.DateInsertion,
                            dateAlteration = user.DateAlteration
                        });

                return affectedRows;
            }
            catch
            {
                //  TO-DO: Adicionar aos erros (Notifiable)
                return 0;
            }
        }

        public async Task<bool> ExistsAsync(string email)
        {
            try
            {
                return await _sqlService
                    .ExistsAsync(UserRepositorySql.UserExistsQuery, new { email });
            }
            catch
            {
                //  TO-DO: Adicionar aos erros (Notifiable)
                return false;
            }
        }

        public async Task<User> GetAsync(string email)
        {
            try
            {
                return await _sqlService.GetAsync<User>(UserRepositorySql.GetUserQuery, new { email })
                    ?? User.Empty();
            }
            catch
            {
                //  TO-DO: Adicionar aos erros (Notifiable)
                return User.Empty();
            }
        }
    }
}
