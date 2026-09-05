using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Sim;

internal class SimulationContext
{
    public required RNG Rng { get; init; }
    public required IReadOnlyList<Person> People { get; init; }
}