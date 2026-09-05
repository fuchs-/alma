using Alma.Kernel.Debugger.Forms;
using Alma.Kernel.Sim;

namespace Alma.Kernel;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        var simulation = new Simulation();
        var runner = new SimulationRunner(simulation);

        var context = simulation.GetDebugContext(
            () => runner.StartAsync()
            );

        Application.Run(new DebugForm(context));
    }
}
