using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Observability;

namespace Alma.Kernel.Debugger.Controls;

internal partial class PersonViewer : ADUserControl
{
    public IPerson? Person { get; set; }

    public override void RefreshUI(bool recursive = true)
    {
        base.RefreshUI(recursive);

        if (Person is null) return;
        _nameLabel!.Text = $"{Person.GetName()}, {Person.GetAge()}";
        _tensionLabel!.Text = $"Tension: {Person.GetNeeds().GetTension()}";
    }
}
