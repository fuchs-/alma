using Alma.Kernel.Observability.Debug;
using Alma.Kernel.Sim.WorkScheduling;

namespace Alma.Kernel.Sim;

public class SimulationController
{
    private readonly Simulation _simulation = new();
    private bool _isMidTick = false;

    public DebugSimulationContext GetDebugSimulationContext() 
        => _simulation.GetDebugContext();

    public WorkResult DoWork()
    {
        if (!_isMidTick)
        {
            _simulation.BeginTick();
            _isMidTick = true;
        }
        
        WorkResult result = _simulation.DoWork();

        if (result == WorkResult.Done)
        {
            _simulation.EndTick();
            _isMidTick = false;
        }
        return result;
    }
}
