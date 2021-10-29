using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class ContactPerson : AppUser, IMapFrom<ContactPersonViewModel>, IMapFrom<ContactPersonCreateViewModel>, IMapFrom<ContactPersonEditViewModel>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public ContactPerson Supervisor { get; set; }

        public bool IsSupervisor
        {
            get
            {
                return this.Supervisor == null;
            }
        }

        public string Position { get; set; }

        public long? SupervisorId { get; set; }

        public bool IsMainContact { get; set; }

        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }

        public long? ProjectId { get; set; }

        public long? CompanyId { get; set; } // Fetching by WHERE CompanyId = Customer.Id OR CompanyId = Supplier.Id

        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
    }
}
