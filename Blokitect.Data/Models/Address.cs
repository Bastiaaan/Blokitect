using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class Address : Model
    {
        public long XCoordinate { get; set; }

        public long YCoordinate { get; set; }

        public string Country { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string Province { get; set; }

        public long StreetNumber { get; set; }

        public long CompanyId { get; set; }

        public Company Company { get; set; } // usually it's a Customer- or Supplier-object because they both inherit from the Company object
    }
}
