using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models.Enums;

namespace Blokitect.Data.ViewModels
{
    public class SupplierRegisterViewModel : RegisterViewModel
    {
        public SupplierRegisterViewModel()
        {
            this.UserRole = UserRole.Supplier;
        }
    }
}
