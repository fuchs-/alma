using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.World.People;
using Alma.Kernel.Utils;
using Alma.Kernel.Systems;

namespace Alma.Kernel.Sim;

internal partial class Simulation
{
    private static readonly int POPULATION = 5;

    private readonly RNG _rng = new();
    private readonly WorkScheduler _scheduler = new();
    private readonly List<Person> _people = [];

    public Simulation()
    {
        var generator = new PersonGenerator();

        for (var i = 0; i < POPULATION; i++)
        {
            _people.Add(
                generator.GeneratePerson()
                );
        }

        var context = GetContext();

        _scheduler.Schedule(
            new PhysiologySystem(context),
            new PsychologySystem(context),
            new ActorsSystem(context)
            );
    }

    public event Action? TickEnded;

    public void BeginTick() => _scheduler.BeginWork();

    public void EndTick()
        => TickEnded?.Invoke();

    public WorkResult DoWork() => _scheduler.DoWork();
}
