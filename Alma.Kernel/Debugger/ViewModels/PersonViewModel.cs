using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.Debugger.ViewModels;

internal class PersonViewModel(IDebugPerson person)
{
    private IDebugPerson _person = person;

    public string Name => _person.GetName();
    public int Age => _person.GetAge();
    public int Tension => _person.GetNeeds().GetTension();
    public string Activity => _person.GetCurrentActivity();
}
