using Alma.Kernel.Observability;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Sim;

internal class SimulationContext
{
    public required RNG Rng { get; init; }
    public required IReadOnlyList<IPerson> People { get; init; }
}
