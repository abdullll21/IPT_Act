using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Activity.Data
{
    public class ActivityContext(DbContextOptions<ActivityContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
