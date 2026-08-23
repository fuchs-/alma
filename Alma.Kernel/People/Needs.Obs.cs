using Alma.Kernel.Observability;

namespace Alma.Kernel.People;

partial class Needs : INeeds
{
    public int GetTension() => Tension.CurrentValue;
}
