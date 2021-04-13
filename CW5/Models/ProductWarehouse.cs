using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CW5.Models
{
    public class ProductWarehouse
    {
        [Required]
        public int IdProduct { get; set; }
        [Required]
        public int IdWarehouse { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Zmienna musi być większa za 0")]
        public int Amount { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}