namespace Alma.Kernel.Meta.WorkScheduling;

internal sealed class WorkScheduler
{
    private readonly List<IScheduledWorker> _allScheduled = [];
    private readonly Queue<IScheduledWorker> _queue = [];

    public void Schedule(IScheduledWorker schedulable) => _allScheduled.Add(schedulable);

    public void BeginWork() => _allScheduled.ForEach(s => _queue.Enqueue(s));

    public WorkResult DoWork()
    {
        IScheduledWorker worker = _queue.Dequeue();
        WorkResult result = worker.DoWork();

        if (result == WorkResult.NotDone)
            _queue.Enqueue(worker);

        return _queue.Count > 0
            ? WorkResult.NotDone
            : WorkResult.Done;
    }
}
