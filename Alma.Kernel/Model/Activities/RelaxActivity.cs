using Alma.Kernel.Model.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Model.Activities;

internal class RelaxActivity(Person performer)
    : Activity(performer, "Relaxing", 5)
{
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