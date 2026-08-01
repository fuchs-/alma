using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Meta;

internal class Simulation
{
    private readonly RNG _rng = new();

    private readonly Space _space = new();
    private readonly Time _time = new();

    private readonly List<Person> _people = new();

    public void Start()
    {
        var generator = new PersonGenerator();
        var person = generator.GeneratePerson();

        _time.AddEntity(person);

        while (person.Needs.Tension.CurrentValue < 100)
        {
            _time.Tick();

            Console.WriteLine($"{person}\ntension: {person.Needs.Tension.CurrentValue}%\n");

            Thread.Sleep(1000);
        }
    }
}