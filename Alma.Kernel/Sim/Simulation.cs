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

        _scheduler.Schedule(new PhysiologySystem(_rng, _people));
    }


    public void BeginTick() => _scheduler.BeginWork();

    public void EndTick()
        => TickEnded?.Invoke(this, EventArgs.Empty);

    public WorkResult DoWork() => _scheduler.DoWork();
}
