using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class CustomerSupplier : ManyToMany, IMapFrom<CustomerSupplierViewModel>
    {
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        [Required]
        public long CustomerId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; }

        [Required]
        public long SupplierId { get; set; }
    }
}
