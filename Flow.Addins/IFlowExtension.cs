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
        ICommand Command { get; }
        IVisualDesign Design { get; }

    }
}
