using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Observability;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm(
    ISimulation simulation,
    Action runSim
    ) : ADForm()
{
    private readonly ISimulation _simulation = simulation;
    private readonly Action _runSimulation = runSim;

    private void DebugForm_Shown(object sender, EventArgs e)
    {
        _personViewer.Person = _simulation.GetAllPeople()[0];

        _simulation.TickEnded +=
            (_, _) => RefreshUI();

        _runSimulation();
    }
}
