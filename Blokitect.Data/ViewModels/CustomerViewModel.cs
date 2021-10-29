using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blokitect.Data.Models;

namespace Blokitect.Data.ViewModels
{
    public class CustomerViewModel : CompanyViewModel, IMapFrom<Customer>
    {
        [Required]
        public long CustomerId { get; set; }

        public CustomerViewModel Customer { get; set; }

        [Required]
        public long ProjectId { get; set; }

        public ProjectViewModel Project { get; set; }
    }

    public class CustomerCreateViewModel : CustomerViewModel { }

    public class CustomerEditViewModel : CustomerCreateViewModel { }
}
