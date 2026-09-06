using Alma.Kernel.Observability.Debug;

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

    public DebugSimulationContext GetDebugContext(Action startSimulation)
    {
        var ret = new DebugSimulationContext()
        {
            StartSimulation = startSimulation,
            People = _people,
        };
        TickEnded += ret.EndTick;

        return ret;
    }
}
