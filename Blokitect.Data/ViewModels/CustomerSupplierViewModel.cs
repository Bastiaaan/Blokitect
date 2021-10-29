using Blokitect.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blokitect.Data.ViewModels
{
    public class CustomerSupplierViewModel : SuperViewModel, IMapFrom<CustomerSupplier>
    {
        [ForeignKey(nameof(CustomerId))]
        public CustomerViewModel Customer { get; set; }

        [Required]
        public long CustomerId { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public SupplierViewModel Supplier { get; set; }

        [Required]
        public long SupplierId { get; set; }
    }
}
