using Alma.Kernel.Debugger.Controls;

namespace Alma.Kernel.Debugger.Forms;

partial class DebugForm
{
    private PeopleDataGridView _peopleDgv;

    protected override void BuildView()
    {
        SetupForm();

        _peopleDgv = new PeopleDataGridView();
        _peopleDgv.Dock = DockStyle.Fill;

        Controls.Add(_peopleDgv);
    }

    private void SetupForm()
    {
        ClientSize = new Size(800, 450);
        Text = "Alma - Debugger";

        Shown += DebugForm_Shown;
    }
}