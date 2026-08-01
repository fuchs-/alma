using Alma.Kernel.Meta;
using Alma.Kernel.Model.Activities;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Model.People;

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

        CurrentActivity = new RelaxActivity(this);

        Console.WriteLine($"{this} decided to satisfy her need!");
    }

    public override string ToString()
    {
        return Identity.Name;
    }
}
