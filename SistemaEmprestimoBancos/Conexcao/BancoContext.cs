using Microsoft.EntityFrameworkCore;
using SistemaEmprestimoBancos.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.Conexcao
{
    public class BancoContext : DbContext
    {
        public DbSet<Banco> bancos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Banco;Trusted_Connection=true;");
        }

    }
}
