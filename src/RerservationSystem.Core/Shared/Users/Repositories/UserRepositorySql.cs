﻿namespace RerservationSystem.Core.Shared.Users.Repositories
{
    public static class UserRepositorySql
    {
        public const string CreateUserQuery = @"
            insert into [USER]
            (
                [USER_ROLE],
                [DOCUMENT],
                [EMAIL],
                [PASSWORD],
                [DATE_INSERTION],
                [DATE_ALTERATION]
            )
            values
            (
                @userRole,
                @document,
                @email,
                @password,
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
    }
}
