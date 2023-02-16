using Microsoft.EntityFrameworkCore;
using Rextur.Domain.Model;

namespace Rextur.Data
{
    public class PassageirosContext : DbContext
    {
        public PassageirosContext(DbContextOptions<PassageirosContext> options)
       : base(options) => Database.EnsureCreated();

        public DbSet<Passageiro> Passageiros { get; set; }

    }
}
