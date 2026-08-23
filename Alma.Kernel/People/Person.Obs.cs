using Alma.Kernel.Observability;

namespace Alma.Kernel.People;

partial class Person : IPerson
{
    public string GetName() => Identity.Name;
    public int GetAge() => Identity.Age;

    public INeeds GetNeeds() => Needs;
}
