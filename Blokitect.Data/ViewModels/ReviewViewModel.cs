using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Blokitect.Data.Models;

namespace Blokitect.Data.ViewModels
{
    public class ReviewViewModel : SuperViewModel, IMapFrom<Review>
    {
        public string Subject { get; set; }

        public string Content { get; set; }

        public long ReviewerId { get; set; }

        [ForeignKey(nameof(ReviewerId))]
        public CustomerViewModel Reviewer { get; set; }

        [ForeignKey(nameof(SupplierId))]
        public SupplierViewModel Supplier { get; set; }

        public long SupplierId { get; set; }

        public long Rating { get; set; }

        public string Website { get; set; }
    }

    public class ReviewCreateViewModel : ReviewViewModel { }

    public class ReviewEditViewModel : ReviewCreateViewModel { }
}
