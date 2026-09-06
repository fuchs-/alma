using Alma.Kernel.Sim;

namespace Alma.Kernel.Systems;

internal class ActorsSystem(SimulationContext simContext)
    : PeopleSystem(
        simContext,
        (p, rng) => p.Act(rng)
        );
