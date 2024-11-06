using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDataBase.Data
{
    public class GameResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        [ForeignKey("Symbol1")]
        public int SymbolId1 { get; set; }
        public Symbol Symbol1 { get; set; }

        [ForeignKey("Symbol2")]
        public int SymbolId2 { get; set; }
        public Symbol Symbol2 { get; set; }

        [ForeignKey("Symbol3")]
        public int SymbolId3 { get; set; }
        public Symbol Symbol3 { get; set; }

        [ForeignKey("Symbol4")]
        public int SymbolId4 { get; set; }
        public Symbol Symbol4 { get; set; }

        public decimal BetAmount { get; set; }
        public decimal WinAmount { get; set; }
    }
}

