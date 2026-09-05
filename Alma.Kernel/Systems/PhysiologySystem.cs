using Alma.Kernel.People;
using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal class PhysiologySystem(
    SimulationContext context
    )
    : IScheduledWorker
{
    private readonly IReadOnlyList<Person> _people = context.People;
    private readonly RNG _rng = context.Rng;
    public WorkResult DoWork()
    {
        foreach (var person in _people)
            person.Needs.Tick(_rng);

        return WorkResult.Done;
    }
}
