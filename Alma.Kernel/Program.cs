using Alma.Kernel.Debugger.Forms;
using Alma.Kernel.Meta;

namespace Alma.Kernel;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var sim = new Simulation();
        sim.Start();

        Application.Run(new DebugForm(sim));

        sim.Stop();
    }
}
