using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace api.Configurations
{
    public static class AuthenticationConfig
    {
         public static void AddAuthenticationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
                        .GetBytes(configuration.GetSection("AppSettings:Token").Value
                            ?? throw new InvalidOperationException("Token value is missing in configuration."))),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
        }
    }
}