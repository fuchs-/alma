using Alma.Kernel.Items;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Observability;

internal interface IPerson
{
    abstract INeeds Needs { get; }
    abstract List<Item> Pockets { get; }

    void Think(RNG rng);
    void Act(RNG rng);
}
