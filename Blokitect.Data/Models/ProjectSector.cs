using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Models
{
    public class ProjectSector : ManyToMany
    {
        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }

        [ForeignKey(nameof(SectorId))]
        public Sector Sector { get; set; }

        [Required]
        public long ProjectId { get; set; }

        [Required]
        public long SectorId { get; set; }
    }
}
