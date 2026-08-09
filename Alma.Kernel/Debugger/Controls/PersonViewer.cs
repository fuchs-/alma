using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.People;

namespace Alma.Kernel.Debugger.Controls;

internal partial class PersonViewer : ADUserControl
{
    public Person? Person { get; set; }

    public override void RefreshUI()
    {
        if (Person is null) return;
        _nameLabel!.Text = Person.Identity.Name;
    }
}
