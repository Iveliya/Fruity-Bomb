using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDataBase.Data
{
    public class Symbol
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Payout { get; set; }

        public ICollection<GameResult> GameResults1 { get; set; }
        public ICollection<GameResult> GameResults2 { get; set; }
        public ICollection<GameResult> GameResults3 { get; set; }
        public ICollection<GameResult> GameResults4 { get; set; }
    }
}

