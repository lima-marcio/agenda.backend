using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
// using Schedule.Interfaces;
// using Schedule.Services;

namespace Agenda.API.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
      // services.AddScoped<IUserService, UserService>();
      // services.AddScoped<ITokenService, TokenService>();
      // services.AddScoped<IAppointmentService, AppointmentService>();
      // services.AddScoped<IConfigurationService, ConfigurationService>();
      // services.AddScoped<IUserService, UserService>();
      // services.AddScoped<ICustomerService, CustomerService>();
      // services.AddScoped<ISupplierService, SupplierService>();
      // services.AddScoped<IOfficeService, OfficeService>();
      return services;
    }

    public static IServiceCollection AddCustomCors(this IServiceCollection services, string policyName)
    {
      services.AddCors(options =>
      {
        options.AddPolicy(policyName,
            builder =>
            {
              builder
                .AllowAnyOrigin()
                .WithOrigins("http://localhost:5173")
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            });
      });
      return services;
    }

    public static IServiceCollection AddCustomAuthentication(this IServiceCollection services, string secretKey)
    {
      var key = Encoding.ASCII.GetBytes(secretKey);
      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
          options.RequireHttpsMetadata = false;
          options.SaveToken = true;
          options.TokenValidationParameters = new TokenValidationParameters
          {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
          };
          options.Events = new JwtBearerEvents
          {
            OnMessageReceived = context =>
            {
              var token = context.Request.Cookies["token"];
              if (!string.IsNullOrEmpty(token))
              {
                context.Token = token;
              }
              return Task.CompletedTask;
            }
          };
        });
      return services;
    }
  }
}