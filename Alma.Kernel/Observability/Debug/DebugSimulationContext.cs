namespace Alma.Kernel.Observability.Debug;

internal class DebugSimulationContext
{
    public required Action StartSimulation { get; init; }
    public required IReadOnlyList<IDebugPerson> People { get; init; }

    public event Action? TickEnded;
    public void EndTick() => TickEnded?.Invoke();
}
