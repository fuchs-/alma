using Alma.Kernel.People;
using Alma.Kernel.Utils;

namespace Alma.Kernel.Meta;

internal class Simulation
{
    private readonly RNG _rng = new();
    private readonly Space _space = new();
    private readonly Time _time = new();
    private readonly List<Person> _people = [];

    public Simulation()
    {
        var generator = new PersonGenerator();
        var person = generator.GeneratePerson();

        _people.Add(person);
        _time.AddEntity(person);
    }

    public void Tick()
    {
        _time.Tick();
    }
}
