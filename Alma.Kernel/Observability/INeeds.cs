using Alma.Kernel.Utils;
using Alma.Kernel.World.People.Body;

namespace Alma.Kernel.Observability;

internal interface INeeds
{
    abstract Need Tension { get; }
    abstract Need Social { get; }

    void Tick(RNG rng);
}
