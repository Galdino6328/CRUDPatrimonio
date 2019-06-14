using Microsoft.EntityFrameworkCore;
using PatrimonioEmpresa.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonioEmpresa.Models.Contexto
{
    public class ContextoMarca : DbContext
    {
        public ContextoMarca(DbContextOptions<ContextoMarca> option) : base(option)
        {
            Database.EnsureCreated();
        }
        public DbSet<Marca> Marca { get; set; }
    }
}
