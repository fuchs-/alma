using Alma.Kernel.People;
using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal abstract class PeopleSystem(
    SimulationContext simContext,
    Action<Person, RNG> action
    )
    : SimulationSystem(simContext)
{
    private readonly Action<Person, RNG> _action = action;

    public override WorkResult DoWork()
    {
        foreach (var person in People)
            _action(person, Rng);

        return WorkResult.Done;
    }
}