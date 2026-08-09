using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Meta;
using Alma.Kernel.People;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm : ADForm
{
    private readonly Simulation _simulation;

    public DebugForm(Simulation simulation)
        : base()
    {
        _simulation = simulation;

        _personViewer.Person = _simulation.People[0];
        _personViewer.RefreshUI();
    }
}
