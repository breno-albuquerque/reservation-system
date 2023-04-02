using RerservationSystem.Core.Shared.Data;
using RerservationSystem.Core.Shared.Results;
using RerservationSystem.Core.Shared.Services.Error;
using RerservationSystem.Core.Shared.Users.Entities;

namespace RerservationSystem.Core.Shared.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlService _sqlService;
        private readonly ErrorService _errorService;

        public UserRepository(ISqlService sqlService, ErrorService errorService)
        {
            _sqlService = sqlService;
            _errorService = errorService;
        }

        public async Task<InsertResult> CreateUserAsync(User user)
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

                return new InsertResult(affectedRows);
            }
            catch (Exception ex)
            {
                _errorService.AddError(ex.Message);
                return new InsertResult(default);
            }
        }

        public async Task<bool> ExistsAsync(string email)
        {
            try
            {
                return await _sqlService
                    .ExistsAsync(UserRepositorySql.UserExistsQuery, new { email });
            }
            catch (Exception ex)
            {
                _errorService.AddError(ex.Message);
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
            catch (Exception ex)
            {
                _errorService.AddError(ex.Message);
                return User.Empty();
            }
        }
    }
}
