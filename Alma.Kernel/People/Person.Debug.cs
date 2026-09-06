using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.People;

partial class Person : IDebugPerson
{
    public string GetName() => Identity.Name;
    public int GetAge() => Identity.Age;

    public IDebugNeeds GetNeeds() => Needs;
    public string GetCurrentActivity()
        => CurrentActivity?.Name ?? "Idle";
}
