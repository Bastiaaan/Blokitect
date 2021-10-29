using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.ViewModels
{
    public class CreatePasswordViewModel
    {
        public ContactPersonViewModel ContactPerson { get; set; }

        [Required]
        [NotMapped] // NotMapped prevents the passwords to be saved as an NVARCHAR in the Database. 
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
