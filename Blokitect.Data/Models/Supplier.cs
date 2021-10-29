using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blokitect.Data.Models.Enums;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class Supplier : Company, IMapFrom<SupplierViewModel>, IMapFrom<SupplierCreateViewModel>, IMapFrom<SupplierEditViewModel>
    {
        [InverseProperty(nameof(Supplier))]
        public virtual ICollection<CustomerSupplier> CustomerSuppliers { get; set; }
        
        [InverseProperty(nameof(Supplier))]
        public virtual ICollection<ProjectSupplier> ProjectSuppliers { get; set; }

        public SupplierType Type { get; set; }

        public IList<Review> Reviews { get; set; }

        public IList<Customer> Customers { get; set; }

        public long PenaultyPoints { get; set; }
        // Penaulty points are designed to make sure that a supplier is going under review by suspects of fraud.

        public bool IsFreelancer { get; set; } // Is een ZZP'er of niet.

    }
}
