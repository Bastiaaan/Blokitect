using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models;
using Blokitect.Data.Models.Enums;

namespace Blokitect.Data.ViewModels
{
    public class FunctionViewModel : SuperViewModel, IMapFrom<Function>
    {
        public long Id { get; set; }

        public ReturnValue ReturnValue { get; set; }

        public ComponentViewModel Component { get; set; }

        public int Priority { get; set; }
    }

    public class FunctionCreateViewModel : FunctionViewModel { }

    public class FunctionEditViewModel : FunctionCreateViewModel { }
}
