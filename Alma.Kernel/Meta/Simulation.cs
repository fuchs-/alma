using Alma.Kernel.Model;
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

        while (person.SocializingNeed < 100)
        {
            _time.Tick();
            Console.WriteLine($"{person} socializing need: {person.SocializingNeed}%");
            Thread.Sleep(1000);
        }
    }
}