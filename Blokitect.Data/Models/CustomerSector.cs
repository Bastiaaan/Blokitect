using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class CustomerSector : ManyToMany
    {
        [Required]
        public long CustomerId { get; set; }

        [Required]
        public long SectorId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        [ForeignKey(nameof(SectorId))]
        public Sector Sector { get; set; }
    }
}
