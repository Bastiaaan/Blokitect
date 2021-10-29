using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class Sector : Model
    {
        public string Name { get; set; }

        [InverseProperty(nameof(Sector))]
        public virtual ICollection<ProjectSector> ProjectSectors { get; set; }

        [InverseProperty(nameof(Sector))]
        public virtual ICollection<CustomerSector> CustomerSectors { get; set; }
    }
}
