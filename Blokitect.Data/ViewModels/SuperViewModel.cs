using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.ViewModels
{
    public abstract class SuperViewModel
    {
        [Key]
        public virtual long Id { get; set; }
    }
}
