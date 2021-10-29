using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models.Enums;

namespace Blokitect.Data.ViewModels
{
    public class CustomerRegisterViewModel : RegisterViewModel
    {
        public CustomerRegisterViewModel()
        {
            this.UserRole = UserRole.Customer;
        }
    }
}
