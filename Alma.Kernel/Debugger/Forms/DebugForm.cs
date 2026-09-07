using Alma.Kernel.Debugger.Controls;
using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm(DebugSimulationContext context)
    : ADForm()
{
    private readonly DebugSimulationContext _context = context;

    private void DebugForm_Shown(object sender, EventArgs e)
    {
        _peopleDgv.SetData(_context.People);

        _context.TickEnded += () => RefreshUI();

        _context.StartSimulation();
    }
}
