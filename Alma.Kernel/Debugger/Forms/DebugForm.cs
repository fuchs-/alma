using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm(DebugSimulationContext context)
    : ADForm()
{
    private readonly DebugSimulationContext _context = context;

    private void DebugForm_Shown(object sender, EventArgs e)
    {
        _personViewer.Person = _context.People[0];
        _context.TickEnded += () => RefreshUI();

        _context.StartSimulation();
    }
}
