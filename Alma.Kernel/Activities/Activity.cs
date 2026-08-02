using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Activities;

internal class Activity(
    Person actor,
    string name,
    int duration
    )
{
    protected Person _actor = actor;
    public string Name { get; } = name;
    public int Duration { get; } = duration;
    public int TicksLeft { get; private set; } = duration;
    public bool Finished => TicksLeft <= 0;

    public virtual bool CanStart() => true;

    public virtual bool Start(RNG rng) => true;

    public virtual bool Tick(RNG rng)
    {
        if (Finished)
            return false;

        TicksLeft--;
        return true;
    }
}