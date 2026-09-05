using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.People;
using Alma.Kernel.Utils;
using Alma.Kernel.Systems;

namespace Alma.Kernel.Sim;

internal partial class Simulation
{
    private readonly RNG _rng = new();
    private readonly WorkScheduler _scheduler = new();
    private readonly List<Person> _people = [];

    public Simulation()
    {
        var generator = new PersonGenerator();
        var person = generator.GeneratePerson();

        _people.Add(person);

        _scheduler.Schedule(new PhysiologySystem(GetContext()));
    }

    public event Action? TickEnded;

    public void BeginTick() => _scheduler.BeginWork();

    public void EndTick()
        => TickEnded?.Invoke();

    public WorkResult DoWork() => _scheduler.DoWork();
}
