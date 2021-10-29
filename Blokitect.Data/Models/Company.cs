using Blokitect.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blokitect.Data.Models
{
    [NotMapped]
    public class Company : Model, IMapFrom<CompanyViewModel>
    {
        public string CompanyName { get; set; }

        public long? ChamberOfCommerceNumber { get; set; }

        public long PhoneNumber { get; set; }

        public string CorrespondenceAddress { get; set; }

        public string MailAddress { get; set; }

        public string ZipCode { get; set; }

        public string Town { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public byte[] Logo { get; set; }

        public IList<ContactPerson> ContactPeople { get; set; }
    }
}