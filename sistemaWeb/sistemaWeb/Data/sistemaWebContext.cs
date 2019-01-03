using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistemaWeb.Models
{
    public class sistemaWebContext : DbContext
    {
        public sistemaWebContext (DbContextOptions<sistemaWebContext> options)
            : base(options)
        {
        }

        public DbSet<sistemaWeb.Models.Categoria> Categoria { get; set; }
    }
}
