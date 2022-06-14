using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalStatistician.IdentityServer.IdentityUsers
{
    public class ApplicationUsersDbContext : IdentityDbContext
    {
        public ApplicationUsersDbContext(DbContextOptions<ApplicationUsersDbContext> options) : base(options)
        {

        }
    }
}
