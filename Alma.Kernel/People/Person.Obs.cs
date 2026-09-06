using Alma.Kernel.Items;
using Alma.Kernel.Observability;

namespace Alma.Kernel.People;

partial class Person : IPerson
{
    public INeeds Needs => _needs;

    public List<Item> Pockets => _pockets;
}
