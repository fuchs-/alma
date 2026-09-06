using Alma.Kernel.People;
using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Systems;

internal abstract class SimulationSystem(
    SimulationContext simContext
    )
    : IScheduledWorker
{
    protected SimulationContext _simContext = simContext;

    protected RNG Rng => _simContext.Rng;
    protected IReadOnlyList<Person> People => _simContext.People;

    public abstract WorkResult DoWork();
}