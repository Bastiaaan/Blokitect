using Blokitect.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blokitect.Data.ViewModels
{
    public class CompanyViewModel : SuperViewModel, IMapFrom<Company>
    {
        public string CompanyName { get; set; }

        public long ChamberOfCommerceNumber { get; set; }

        public string VATNumber { get; set; }

        public string MailAddress { get; set; }

        public string CorrespondenceAddress { get; set; }

        public long PhoneNumber { get; set; }

        public byte[] Logo { get; set; }

        public IList<ContactPersonViewModel> ContactPeople { get; set; }
    }
}
