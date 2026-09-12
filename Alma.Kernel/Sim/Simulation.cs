using Alma.Kernel.Sim.WorkScheduling;
using Alma.Kernel.World.People;
using Alma.Kernel.Utils;
using Alma.Kernel.Systems;
using Alma.Kernel.World;

namespace Alma.Kernel.Sim;

internal partial class Simulation
{
    private static readonly int POPULATION = 5;

    private readonly RNG _rng = new();
    private readonly WorkScheduler _scheduler = new();
    private readonly List<Person> _people = [];
    private readonly City _city = new();

    public Simulation()
    {
        GeneratePopulation();

        _city.Generate(_people);

        var context = GetContext();

        _scheduler.Schedule(
            new PhysiologySystem(context),
            new PsychologySystem(context),
            new ActorsSystem(context)
            );
    }

    private void GeneratePopulation()
    {
        var generator = new PersonGenerator(_rng);

        for (var i = 0; i < POPULATION; i++)
        {
            _people.Add(
                generator.GeneratePerson()
                );
        }
    }

    public void BeginTick() => _scheduler.BeginWork();

    public void EndTick()
        => TickEnded?.Invoke();

    public WorkResult DoWork() => _scheduler.DoWork();

    public event Action? TickEnded;
}
