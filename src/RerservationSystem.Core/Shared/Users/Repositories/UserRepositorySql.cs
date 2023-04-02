namespace RerservationSystem.Core.Shared.Users.Repositories
{
    public static class UserRepositorySql
    {
        public const string CreateUserQuery = @"
            insert into [USER]
            (
                [USER_ROLE],
                [DOCUMENT],
                [EMAIL],
                [PASSWORD_HASH],
                [DATE_INSERTION],
                [DATE_ALTERATION]
            )
            values
            (
                @userRole,
                @document,
                @email,
                @passwordHash,
                @dateInsertion,
                @dateAlteration
            )";

        public const string UserExistsQuery = @"
            select 
                count(1)
            from 
                [USER]
            where
                [EMAIL] = @email
            ";

        public const string GetUserQuery = @"
            select 
                [ID] as Id,
                [EMAIL] as Email,
                [DOCUMENT] as Document,
                [USER_ROLE] as UserRole,
                [PASSWORD_HASH] as PasswordHash,
                [DATE_INSERTION] as DateInsertion,
                [DATE_ALTERATION] as DateAlteration
            from 
                [USER]
            where
                [EMAIL] = @email
            ";
    }
}
