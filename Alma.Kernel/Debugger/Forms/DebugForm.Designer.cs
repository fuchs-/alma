using Alma.Kernel.Debugger.Controls;

namespace Alma.Kernel.Debugger.Forms;

partial class DebugForm
{
    private PersonViewer _personViewer;

    protected override void BuildView()
    {
        SetupForm();

        _personViewer = new PersonViewer();
        Controls.Add(_personViewer);
    }

    private void SetupForm()
    {
        ClientSize = new Size(800, 450);
        Text = "Alma - Debugger";

        Shown += DebugForm_Shown;
    }
}