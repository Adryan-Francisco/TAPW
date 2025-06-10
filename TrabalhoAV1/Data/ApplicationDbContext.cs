using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TrabalhoAV1.Models;

namespace TrabalhoAV1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
    }
}
