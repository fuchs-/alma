using Alma.Kernel.World.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Observability;

internal interface INeeds
{
    abstract Need Tension { get; }

    void Tick(RNG rng);
}
