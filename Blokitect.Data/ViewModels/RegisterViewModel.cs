using Blokitect.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blokitect.Data.ViewModels
{
    public class RegisterViewModel
    {
        //[Required]
        public string CompanyName { get; set; }

        //[Required]
        public long ChamberOfCommerceNumber { get; set; }

        //[Required]
        public string VATNumber { get; set; }

        //[Required]
        public string MailAddress { get; set; }

        //[Required]
        public long PhoneNumber { get; set; }

        public string Website { get; set; }

        //[Required]
        public string Sectors { get; set; }

        public string CorrespondenceAddress { get; set; }

        public string ZipCode { get; set; }

        //[Required]
        public string Activities { get; set; }

        public IList<ContactPersonCreateViewModel> ContactPeople { get; set; }

        public UserRole UserRole { get; set; }
    }
}
