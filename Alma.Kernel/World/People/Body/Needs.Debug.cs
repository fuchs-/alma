using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.World.People.Body;

partial class Needs : IDebugNeeds
{
    public int GetTension() => Tension.CurrentValue;
    public int GetSocial() => Social.CurrentValue;
}
