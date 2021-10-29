using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class Invoice : Model
    {
        public long TavPercentage { get; set; }

        public Project Project { get; set; }

        public string Description { get; set; }

        public Customer Customer { get; set; }

        public Supplier Supplier { get; set; }

        public bool IsPaid { get; set; }

        public bool PaidPercentage { get; set; }

        public int Commission { get; set; } 
        // 5% for basic freelancers, 7.5% for freelancers with prime plan, 10% for companies with basic plan or 20% for coorperations with premium plan
    }
}
