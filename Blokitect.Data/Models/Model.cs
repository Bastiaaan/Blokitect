using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blokitect.Data.Models
{
    [NotMapped]
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long Id { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Modified { get; set; }

        public string Modifier { get; set; }
    }
}
