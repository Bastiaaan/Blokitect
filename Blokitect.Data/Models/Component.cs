using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class Component : Model, IMapFrom<ComponentViewModel>, IMapFrom<ComponentCreateViewModel>, IMapFrom<ComponentEditViewModel>
    {
        public long Type { get; set; }

        public IList<Function> Functions { get; set; }

        public long ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
