using Alma.Kernel.Utils;

namespace Alma.Kernel.Meta;

internal interface ITemporalEntity
{
    void Tick(RNG rng);
}
