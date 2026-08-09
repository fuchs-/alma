using Alma.Kernel.Debugger.Controls;

namespace Alma.Kernel.Debugger.Forms;

partial class DebugForm
{
    private PersonViewer _personViewer;

    protected override void BuildView()
    {
        ClientSize = new Size(800, 450);
        Text = "Alma - Debugger";

        _personViewer = new PersonViewer();
        Controls.Add(_personViewer);
    }
}