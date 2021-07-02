using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ma9.Data.Contexts
{
    public class MeuIdentityDbContext : IdentityDbContext
    {
        public MeuIdentityDbContext(DbContextOptions<MeuIdentityDbContext> options) : base(options) { }
    }
}
