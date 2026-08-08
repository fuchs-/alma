using System.Threading;
using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Meta;

internal class Simulation
{
    private readonly RNG _rng = new();

    private readonly Space _space = new();
    private readonly Time _time = new();

    private readonly List<Person> _people = new();

    private Thread? _thread;
    private CancellationTokenSource? _cancellationTokenSource;

    public void Start()
    {
        _cancellationTokenSource = new();
        _thread = new Thread(() => Run(_cancellationTokenSource.Token));
        _thread.Start();
    }

    public void Stop() => _cancellationTokenSource?.Cancel();

    public void Run(CancellationToken cancelationToken)
    {
        var generator = new PersonGenerator();
        var person = generator.GeneratePerson();

        _time.AddEntity(person);

        var ticks = 0;
        while (!cancelationToken.IsCancellationRequested
            && ticks < 150)
        {
            _time.Tick();
            ticks++;

            Console.WriteLine($"{person}\ntension: {person.Needs.Tension.CurrentValue}%\n");

            Thread.Sleep(1000);
        }
    }
}