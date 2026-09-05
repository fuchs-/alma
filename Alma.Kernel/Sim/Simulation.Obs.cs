using Alma.Kernel.Observability;

namespace Alma.Kernel.Sim;

partial class Simulation
{
    private SimulationContext GetContext()
    {
        return new SimulationContext()
        {
            Rng = _rng,
            People = _people,
        };
    }

    public DebuggerSimulationContext GetDebugContext(Action startSimulation)
    {
        var ret = new DebuggerSimulationContext()
        {
            StartSimulation = startSimulation,
            People = _people,
        };
        TickEnded += ret.EndTick;

        return ret;
    }
}
