using Alma.Kernel.Debugger.Forms;

namespace Alma.Kernel;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new DebugForm());
    }
}
