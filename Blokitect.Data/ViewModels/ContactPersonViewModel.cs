using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Blokitect.Data.Models;

namespace Blokitect.Data.ViewModels
{
    public class ContactPersonViewModel : SuperViewModel, IMapFrom<ContactPerson>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string BusinessFunction { get; set; }

        public ContactPersonViewModel Supervisor { get; set; }

        public bool IsSupervisor
        {
            get
            {
                return this.Supervisor == null;
            }
        }

        public bool IsMainContact { get; set; }

        public long CompanyId { get; set; }

        public CompanyViewModel Company { get; set; }

        public string Position { get; set; }
    }

    public class ContactPersonCreateViewModel : ContactPersonViewModel {  }

    public class ContactPersonEditViewModel : ContactPersonCreateViewModel  {  }
}
