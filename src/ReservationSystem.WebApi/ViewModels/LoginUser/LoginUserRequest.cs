﻿using System.Text.Json.Serialization;

namespace ReservationSystem.WebApi.ViewModels.LoginUser
{
    public class LoginUserRequest
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
