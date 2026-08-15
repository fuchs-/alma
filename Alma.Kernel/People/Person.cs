using Alma.Kernel.Activities;
using Alma.Kernel.Items;
using Alma.Kernel.Meta;
using Alma.Kernel.Utils;
using Alma.Kernel.World;

namespace Alma.Kernel.People;

internal class Person : ITemporalEntity
{
    #region Characteristics

    public required PersonIdentity Identity { get; init; }

    #endregion

    #region State

    public Needs Needs { get; } = new Needs();
    public Activity? CurrentActivity { get; private set; }

    public Place? Location { get; private set; }
    public void _SetLocation(Place place)
    {
        Location = place;
    }

    public List<Item> Pockets { get; } = [new Item("Bloom")];

    #endregion

    public void Tick(RNG rng)
    {
        Needs.Tick(rng);

        if (CurrentActivity is null)
        {
            Decide(rng);
            return;
        }

        CurrentActivity.Tick(rng);
        if (CurrentActivity.Finished)
            CurrentActivity = null;
    }

    private void Decide(RNG rng)
    {
        var need = Needs.FirstOrDefault(n => n.IsUrgent);
        if (need is null) return;

        if (Pockets.Any(i => i.Name == "Bloom"))
        {
            CurrentActivity = new RelaxActivity(this);
        }
        else
        {
            CurrentActivity = new LookForItemActivity(this, "Bloom");
        }

        if (!CurrentActivity.CanStart())
            CurrentActivity = null;

        CurrentActivity?.Start(rng);
    }

    public override string ToString()
    {
        return Identity.Name;
    }
}
