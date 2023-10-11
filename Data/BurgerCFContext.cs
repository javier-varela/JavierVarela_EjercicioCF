using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JavierVarela_EjercicioCF.Models;

namespace BurguerCF.Data
{
    public class BurgerCFContext : DbContext
    {
        public BurgerCFContext (DbContextOptions<BurgerCFContext> options)
            : base(options)
        {
        }

        public DbSet<JavierVarela_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }
}
