using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.People;
using Alma.Kernel.Utils;

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
    }


    public void BeginTick()
    {
        _scheduler.BeginWork();
    }

    public void EndTick()
    {
        TickEnded?.Invoke(this, EventArgs.Empty);
    }

    public WorkResult DoWork()
    {
        return _scheduler.DoWork();
    }
}
