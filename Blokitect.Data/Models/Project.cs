using Blokitect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blokitect.Data.Models
{
    public class Project : Model, IMapFrom<ProjectViewModel>, IMapFrom<ProjectCreateViewModel>, IMapFrom<ProjectEditViewModel>
    {
        public long Progress { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public IList<Component> Components { get; set; }

        [InverseProperty(nameof(Project))]
        public virtual ICollection<ProjectSupplier> ProjectSuppliers { get; set; }
        
        [InverseProperty(nameof(Project))]
        public virtual ICollection<ProjectSector> ProjectSectors { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public long CustomerId { get; set; }

        public bool IsActive { get; set; }

        public bool IsOnline { get; set; }

        public bool IsFinished { get; set; }

        public bool IsPaid { get; set; }

        public IList<ContactPerson> ContactPeople { get; set; }
    }
}
