using Alma.Kernel.Meta.WorkScheduling;

namespace Alma.Kernel.Meta;

internal class SimulationRunner
{
    public async Task StartAsync()
    {
        var simulation = new Simulation();

        simulation.BeginTick();
        WorkResult result = WorkResult.NotDone;

        while (true)
        {
            if (result == WorkResult.NotDone)
            {
                await Task.Delay(10);
                result = simulation.DoWork();
            }
            else
            {
                //TODO: delay till next second
                await Task.Delay(1000);

                simulation.BeginTick();
                result = WorkResult.NotDone;
            }
        }
    }
}