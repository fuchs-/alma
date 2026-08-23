namespace Alma.Kernel.Sim.WorkScheduling;

internal sealed class WorkScheduler
{
    private readonly Queue<IScheduledWorker> _workingQ = [];
    private readonly Queue<IScheduledWorker> _doneQ = [];

    public void Schedule(IScheduledWorker schedulable) => _doneQ.Enqueue(schedulable);

    public void BeginWork()
    {
        while (_doneQ.Count > 0)
            _workingQ.Enqueue(_doneQ.Dequeue());
    }

    public WorkResult DoWork()
    {
        if (!_workingQ.TryDequeue(out var worker))
            return WorkResult.Done;

        WorkResult result = worker.DoWork();

        if (result == WorkResult.NotDone)
            _workingQ.Enqueue(worker);
        else
            _doneQ.Enqueue(worker);

        return _workingQ.Count > 0
            ? WorkResult.NotDone
            : WorkResult.Done;
    }
}
