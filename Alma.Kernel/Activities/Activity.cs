using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Activities;

internal class Activity(
    Person performer,
    string name,
    int duration
    )
{
    protected Person _performer = performer;
    public string Name { get; } = name;
    public int Duration { get; } = duration;
    public int TicksLeft { get; private set; } = duration;
    public bool Finished => TicksLeft <= 0;

    public virtual bool CanStart() => true;

    public virtual bool Start(RNG rng) => true;

    public virtual bool Tick(RNG rng)
    {
        var ret = !Finished;

        if (ret) TicksLeft--;

        return ret;
    }
}