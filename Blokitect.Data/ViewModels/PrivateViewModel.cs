using Blokitect.Data.Framework;
using Blokitect.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.ViewModels
{
    public class PrivateViewModel : SuperViewModel, IMapFrom<Private>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }

        public IList<ProjectViewModel> Projects { get; set; }
    }

    public class PrivateCreateViewModel : PrivateViewModel { }

    public class PrivateEditViewModel : PrivateCreateViewModel { }
}
