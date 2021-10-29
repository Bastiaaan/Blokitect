using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class Review : Model, IMapFrom<ReviewViewModel>, IMapFrom<ReviewCreateViewModel>, IMapFrom<ReviewEditViewModel>
    {
        public string Subject { get; set; }

        public string Content { get; set; }

        public long CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; }

        public long SupplierId { get; set; }

        public long Rating { get; set; }

        public bool IsImproved { get; set; }
    }
}
