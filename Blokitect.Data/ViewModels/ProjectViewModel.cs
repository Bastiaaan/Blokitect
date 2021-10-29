using Blokitect.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blokitect.Data.ViewModels
{
    public class ProjectViewModel : SuperViewModel, IMapFrom<Project>
    {
        public long Progress { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [MinLength(50)]
        public string Description { get; set; }

        public IList<ComponentViewModel> Components { get; set; }

        public CustomerViewModel Customer { get; set; }

        public bool IsActive { get; set; }

        public bool IsOnline { get; set; }

        public bool IsFinished { get; set; }
    }
    public class ProjectCreateViewModel : ProjectViewModel {  }

    public class ProjectEditViewModel : ProjectCreateViewModel {  }
}
