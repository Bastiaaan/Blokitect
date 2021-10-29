using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models;

namespace Blokitect.Data.ViewModels
{
    public class ComponentViewModel : SuperViewModel, IMapFrom<Component>
    {
        public long Type { get; set; }

        public IList<FunctionViewModel> Functions { get; set; }

        public long ProjectId { get; set; }

        public ProjectViewModel Project { get; set; }
    }

    public class ComponentCreateViewModel : ComponentViewModel { }

    public class ComponentEditViewModel : ComponentCreateViewModel { }
}
