using Microsoft.EntityFrameworkCore;
using PatrimonioEmpresa.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrimonioEmpresa.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Patrimonio> Patrimonio { get; set; }
    }
}
