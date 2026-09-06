using Alma.Kernel.Observability;
using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal abstract class PeopleSystem(
    SimulationContext simContext,
    Action<IPerson, RNG> action
    )
    : SimulationSystem(simContext)
{
    private readonly Action<IPerson, RNG> _action = action;

    public override WorkResult DoWork()
    {
        foreach (var person in People)
            _action(person, Rng);

        return WorkResult.Done;
    }
}