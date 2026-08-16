namespace Alma.Kernel.Meta.WorkScheduling;

internal interface IScheduledWorker
{
    WorkResult DoWork();
}
