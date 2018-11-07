using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaAct_Complementarias.Models
{
    public class SistemaAct_ComplementariasContext : DbContext
    {
        public SistemaAct_ComplementariasContext(DbContextOptions<SistemaAct_ComplementariasContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaAct_Complementarias.Models.actividad> actividad { get; set; }
    }
}
