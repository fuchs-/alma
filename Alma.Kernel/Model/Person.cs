using Alma.Kernel.Meta;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Model;

internal class Person : ITemporalEntity
{
    public required PersonIdentity Identity { get; init; }
    public Place? Location { get; private set; }

    private int _SocializingNeed { get; set; } = 50;

    public int SocializingNeed
    {
        get => _SocializingNeed;
        private set => _SocializingNeed = Math.Min(Math.Max(value, 0), 100);
    }

    public void _SetLocation(Place place)
    {
        Location = place;
    }

    public override string ToString()
    {
        return Identity.Name;
    }

    public void Tick(RNG rng)
    {
        SocializingNeed += rng.Generate(5);
    }
}
