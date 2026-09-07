using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.World.People;

partial class Person : IDebugPerson
{
    public string GetName() => Identity.Name;
    public int GetAge() => Identity.Age;

    public IDebugNeeds GetNeeds() => _needs;
    public string GetCurrentActivity()
        => CurrentActivity?.Name ?? "Idle";
}
