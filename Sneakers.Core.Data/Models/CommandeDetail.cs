using Sneakers.Core.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sneakers.Core.Data.Models
{
    public class CommandeDetail
    {
        [Key]
        public  int CommandeDetailId { get; set; }

        public int SneakerId { get; set; }

        public int Amount { get; set; }

        public decimal Prix { get; set; }

        public  Sneaker Sneaker { get; set; }

        [ForeignKey("Commande")]
        public int CommandeId { get; set; }

        public Commande Commande { get; set; }
    }
}
