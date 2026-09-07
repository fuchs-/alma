using Alma.Kernel.World.Items;
using Alma.Kernel.Observability;

namespace Alma.Kernel.World.People;

partial class Person : IPerson
{
    public INeeds Needs => _needs;

    public List<Item> Pockets => _pockets;
}
