using Alma.Kernel.Meta;

namespace Alma.Kernel;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        //TODO: Launch simulation on separate Thread
        //(new Simulation()).Start();

        Application.Run(new MainForm());
    }
}