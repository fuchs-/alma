using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;

namespace Alma.Kernel.Systems;

internal class PsychologySystem(
    SimulationContext simContext
    )
    : PeopleSystem(
        simContext,
        (p, rng) => p.Think(rng)
        );
