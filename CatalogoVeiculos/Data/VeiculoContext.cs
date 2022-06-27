using CatalogoVeiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoVeiculos.Data
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options)
        {
        }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
