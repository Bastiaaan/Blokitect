using System;
using System.Collections.Generic;
using System.Text;
using Blokitect.Data.Models.Enums;
using Blokitect.Data.ViewModels;

namespace Blokitect.Data.Models
{
    public class Function : Model, IMapFrom<FunctionViewModel>, IMapFrom<FunctionCreateViewModel>, IMapFrom<FunctionEditViewModel>
    {
        public ReturnValue ReturnValue { get; set; }

        public Component Component { get; set; }

        public int Priority { get; set; }
    }
}
