using System.Diagnostics;
using Alma.Kernel.Observability.Debug;
using Alma.Kernel.Sim;
using Alma.Kernel.Sim.WorkScheduling;

namespace Alma.Debugger;

internal class SimulationRunner
{
    private readonly SimulationController _simController = new();
    private readonly TimeSpan TickDuration = TimeSpan.FromSeconds(1);

    public DebugSimulationContext GetContext() 
        => _simController.GetDebugSimulationContext();
    
    public async Task Run(CancellationToken token)
    {
        var nextTickAt = TickDuration;
        var stopwatch = Stopwatch.StartNew();
        
        while (!token.IsCancellationRequested)
        {
            var result = _simController.DoWork();

            if (result == WorkResult.NotDone)
            {
                await Task.Delay(10, token);
                continue;
            }

            var remaining = nextTickAt - stopwatch.Elapsed;
            if (remaining > TimeSpan.Zero)
            {
                await Task.Delay(remaining, token);
            }

            while (nextTickAt <= stopwatch.Elapsed)
                nextTickAt += TickDuration;
        }
    }
}