using Alma.Kernel.Sim;

namespace Alma.Kernel.Systems;

internal class PhysiologySystem(
    SimulationContext context
    )
    : PeopleSystem(
        context,
        (p, rng) => p.Needs.Tick(rng)
        );
