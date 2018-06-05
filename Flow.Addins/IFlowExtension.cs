using Flow.Addins.Commands;
using Flow.Addins.VisualDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.Extensions
{
    public interface IFlowExtension
    {
        ICommand command { get; }
        IVisualDesign design { get; }

    }
}
