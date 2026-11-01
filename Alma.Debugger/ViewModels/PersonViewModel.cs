using Alma.Kernel.Observability.Debug;

namespace Alma.Debugger.ViewModels;

public class PersonViewModel(IDebugPerson person)
{
    private readonly IDebugPerson _person = person;

    public string Name => _person.GetName();
    public int Age => _person.GetAge();
    public int Tension => _person.GetNeeds().GetTension();
    public string Activity => _person.GetCurrentActivity();
}