using Blokitect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blokitect.Data.Models
{
    public class Customer : Company, IMapFrom<CustomerViewModel>, IMapFrom<CustomerCreateViewModel>, IMapFrom<CustomerEditViewModel>, IMapFrom<RegisterViewModel>
    {
        public IList<Project> Projects { get; set; }

        [InverseProperty(nameof(Customer))]
        public virtual ICollection<CustomerSupplier> CustomerSuppliers { get; set; }

        [InverseProperty(nameof(Customer))]
        public virtual ICollection<CustomerSector> CustomerSectors { get; set; }
    }
}
