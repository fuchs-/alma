using Alma.Kernel.Debugger;
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

        Application.Run(new MainForm());

        sim.Stop();
    }
}
