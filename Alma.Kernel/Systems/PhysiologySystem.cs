using Alma.Kernel.People;
using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal class PhysiologySystem(
    RNG rng,
    IReadOnlyList<Person> people
    )
    : IScheduledWorker
{
    private readonly IReadOnlyList<Person> _people = people;
    private readonly RNG _rng = rng;
    public WorkResult DoWork()
    {
        foreach (var person in _people)
            person.Needs.Tick(_rng);

        return WorkResult.Done;
    }
}
