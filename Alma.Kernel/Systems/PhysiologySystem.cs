using Alma.Kernel.People;
using Alma.Kernel.Sim;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal class PhysiologySystem(
    SimulationContext context
    )
    : PeopleSystem(
        context,
        (p, rng) => p.Needs.Tick(rng)
        )
{
    private readonly IReadOnlyList<Person> _people = context.People;
    private readonly RNG _rng = context.Rng;
}
