using Alma.Kernel.Meta;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Model.People;

internal class Person : ITemporalEntity
{
    #region Profile

    public required PersonIdentity Identity { get; init; }

    #endregion

    #region State

    public Needs Needs { get; } = new Needs();

    public Place? Location { get; private set; }
    public void _SetLocation(Place place)
    {
        Location = place;
    }

    #endregion

    public override string ToString()
    {
        return Identity.Name;
    }

    public void Tick(RNG rng)
    {
        Needs.Socialize.Increase(rng.Generate(8));
    }
}
