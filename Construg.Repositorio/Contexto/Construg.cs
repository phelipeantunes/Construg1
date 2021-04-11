using Construg.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Construg.Repositorio.Contexto
{
    public class ConstrugContexto : DbContext
    {
       

        public DbSet <Usuario> Usuario { get; set; }
        public DbSet<Service> Servicos { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }

        public ConstrugContexto( DbContextOptions options) : base(options)
        {
        }

    }
}
