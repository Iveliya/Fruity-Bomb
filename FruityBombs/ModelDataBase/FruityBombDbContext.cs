using Microsoft.EntityFrameworkCore;
using ModelDataBase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDataBase
{
    public class FruityBombDbContext : DbContext
    {
        public FruityBombDbContext():base()
            {
            }
        public DbSet<GameResult> GameResultss { get; set; }
        public DbSet<PayoutRules> PayoutRuless { get; set; }
        public DbSet<Player> Players { get; set; }   
        public DbSet<Symbol> Symbols { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-63IMCT7\\SQLEXPRESS;Initial Catalog=JuiceBomb;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
