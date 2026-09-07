using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.World.People;

partial class Needs : IDebugNeeds
{
    public int GetTension() => Tension.CurrentValue;
}
