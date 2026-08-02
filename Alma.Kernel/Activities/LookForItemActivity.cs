using Alma.Kernel.Items;
using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Activities;

internal class LookForItemActivity(Person actor, string itemName)
    : Activity(actor, "Looking for " + itemName, 2)
{
    private readonly string _itemName = itemName;

    public override bool Tick(RNG rng)
    {
        if (base.Tick(rng))
        {
            if (Finished)
                _actor.Pockets.Add(new Item(_itemName));

            return true;
        }
        return false;
    }
}