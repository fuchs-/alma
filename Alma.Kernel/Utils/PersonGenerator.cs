using Alma.Kernel.Model.People;

namespace Alma.Kernel.Utils;

internal class PersonGenerator
{
    private readonly RNG _rng = new();

    private readonly string[] _firstNames = File.ReadAllLines("Assets/first_names.lst");
    private readonly string[] _lastNames = File.ReadAllLines("Assets/last_names.lst");

    private const int MinimumAge = 7;
    private const int MaximumAge = 21;

    public Person GeneratePerson() => new()
    {
        Identity = new PersonIdentity(
            _rng.ChooseFrom(_firstNames),
            _rng.ChooseFrom(_lastNames),
            _rng.Generate(MaximumAge + 1, MinimumAge)
            ),
    };
}
