using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalStatistician.Identity.IdentityUsers
{
    public class ApplicationUsersDbContext : IdentityDbContext
    {
        public ApplicationUsersDbContext(DbContextOptions<ApplicationUsersDbContext> options) : base(options)
        {

        }
    }
}
