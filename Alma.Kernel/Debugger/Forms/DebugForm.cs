using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Meta;

namespace Alma.Kernel.Debugger.Forms;

internal partial class DebugForm : ADForm
{
    private async void DebugForm_Shown(object sender, EventArgs e)
    {
        var simulation = new Simulation();
        var ticks = 0;

        while (ticks < 300)
        {
            simulation.Tick();
            ticks++;

            await Task.Delay(1000);
        }

        //_personViewer.Person = _simulation.People[0];
        //_personViewer.RefreshUI();
    }
}
