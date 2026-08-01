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

        Console.WriteLine($"{this} is {CurrentActivity?.Name ?? "Doing nothing"}");
    }

    private void Decide(RNG rng)
    {
        var need = Needs.FirstOrDefault(n => n.IsUrgent);
        if (need is null) return;

        var act = new RelaxActivity(this);

        if (!act.CanStart()) return;

        CurrentActivity = act;

        if (CurrentActivity.Start(rng))
            Console.WriteLine($"{this} decided to satisfy her need!");
        else
            CurrentActivity = null;
    }

    public override string ToString()
    {
        return Identity.Name;
    }
}
