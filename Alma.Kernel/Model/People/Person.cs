using Alma.Kernel.Meta;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Model.People;

internal class Person : ITemporalEntity
{
    #region Characteristics

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
        Needs.Tick(rng);
        Decide(rng);
    }

    private void Decide(RNG rng)
    {
        var need = Needs.FirstOrDefault(n => n.IsUrgent);
        if (need is null) return;

        need.Satisfy();

        Console.WriteLine($"{this} decided to satisfy her need");
    }
}
