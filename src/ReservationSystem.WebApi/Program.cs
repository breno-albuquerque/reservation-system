using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RerservationSystem.Core;
using RerservationSystem.Core.Shared.Configurations;
using ReservationSystem.WebApi.Extensions;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

configureAuthentication(builder);
configureServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

void configureAuthentication(WebApplicationBuilder builder)
{
    JwtConfiguration.Key = builder.Configuration.GetValue<string>("JwtConfiguration:Key");
    var key = Encoding.ASCII.GetBytes(JwtConfiguration.Key);

    builder.Services.AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x =>
    {
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateActor = false
        };
    });
}

void configureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();
    builder.Services.AddWebApi();
    builder.Services.AddCore();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
