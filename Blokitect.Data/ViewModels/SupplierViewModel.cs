using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models;
using Blokitect.Data.Models.Enums;

namespace Blokitect.Data.ViewModels
{
    public class SupplierViewModel : CompanyViewModel, IMapFrom<Supplier>
    {
        public SupplierType Type { get; set; }

        public long PenaultyPoints { get; set; }
    }

    public class SupplierCreateViewModel : SupplierViewModel { }

    public class SupplierEditViewModel : SupplierCreateViewModel {}
}
