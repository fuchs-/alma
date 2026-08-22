using Alma.Kernel.Sim.WorkScheduling;

namespace Alma.Kernel.Sim;

internal class SimulationRunner(Simulation sim)
{
    private readonly Simulation _simulation = sim;

    public async Task StartAsync()
    {
        _simulation.BeginTick();
        WorkResult result = WorkResult.NotDone;

        while (true)
        {
            if (result == WorkResult.NotDone)
            {
                await Task.Delay(10);
                result = _simulation.DoWork();
            }
            else
            {
                //TODO: delay till next second
                await Task.Delay(1000);

                _simulation.BeginTick();
                result = WorkResult.NotDone;
            }
        }
    }
}