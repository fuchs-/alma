namespace Alma.Kernel.Sim.WorkScheduling;

internal interface IScheduledWorker
{
    WorkResult DoWork();
}
