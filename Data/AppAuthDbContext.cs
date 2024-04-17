using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnet8_web_api_identity_api.Data
{
    public class AppAuthDbContext : IdentityDbContext<IdentityUser>
    {
        public AppAuthDbContext(DbContextOptions<AppAuthDbContext> options) : base(options)
        { }
    }
}
