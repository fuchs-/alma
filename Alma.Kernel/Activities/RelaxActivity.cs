using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Activities;

internal class RelaxActivity(Person performer)
    : Activity(performer, "Relaxing", 5)
{
    public override bool CanStart()
    {
        return base.CanStart()
            && _performer.Pockets.Any(i => i.Name == "Bloom");
    }

    public override bool Start(RNG rng)
    {
        if (!base.Start(rng)) return false;

        return _performer.Pockets.Remove(
            _performer
                .Pockets
                .First(i => i.Name == "Bloom")
            );
    }

    public override bool Tick(RNG rng)
    {
        if (base.Tick(rng))
        {
            _performer.Needs.Tension.Satisfy(rng);
            return true;
        }

        return false;
    }
}