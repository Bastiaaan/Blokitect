using Blokitect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class Private : Model, IMapFrom<PrivateViewModel>, IMapFrom<PrivateCreateViewModel>, IMapFrom<PrivateEditViewModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public IList<Project> Projects { get; set; }
    }
}
