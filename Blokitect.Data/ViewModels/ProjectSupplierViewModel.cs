using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Blokitect.Data.Models;

namespace Blokitect.Data.ViewModels
{
    public class ProjectSupplierViewModel : IMapFrom<ProjectSupplier>
    {
        [Required]
        public long ProjectId { get; set; }

        public ProjectViewModel Project { get; set; }

        [Required]
        public long SupplierId { get; set; }

        public SupplierViewModel Supplier { get; set; }
    }
}
