using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Sim;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm : ADForm
{
    private async void DebugForm_Shown(object sender, EventArgs e)
    {
        var simulation = new Simulation();

        var runner = new SimulationRunner(simulation);
        await runner.StartAsync();

        //_personViewer.Person = simulation.People[0];
        //_personViewer.RefreshUI();
    }
}
