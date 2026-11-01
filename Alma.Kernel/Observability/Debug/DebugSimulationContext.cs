namespace Alma.Kernel.Observability.Debug;

public class DebugSimulationContext
{
    public required IReadOnlyList<IDebugPerson> People { get; init; }

    public event Action? TickEnded;
    public void EndTick() => TickEnded?.Invoke();
}
