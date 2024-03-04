using EasyParking.Core.Entities.Identity;
using EasyParking.Core.Services;
using EasyParking.Repository.Identity;
using EasyParking.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace EasyParking.APIs.ExtenTions
{
	public static class IdentityServicesExtentions
	{
		public static IServiceCollection AddIdentityServices(this IServiceCollection Services)
		{

			Services.AddScoped<ITokenService, TokenService>();
			//Services.AddEndpointsApiExplorer();

			Services.AddIdentity<AppUser, IdentityRole>(options =>
			{
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;	
				options.Password.RequireNonAlphanumeric = true;
			}).AddEntityFrameworkStores<AppIdentityDbContext>();
			Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

			return Services;
		}
		
	}
}
