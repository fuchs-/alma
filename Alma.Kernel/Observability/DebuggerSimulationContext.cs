namespace Alma.Kernel.Observability;

internal class DebuggerSimulationContext
{
    public required Action StartSimulation { get; init; }
    public required IReadOnlyList<IPerson> People { get; init; }

    public event Action? TickEnded;
    public void EndTick() => TickEnded?.Invoke();
}
