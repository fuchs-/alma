using Alma.Kernel.World.People;

namespace Alma.Kernel.World;

internal class City
{
    private readonly Place _streets = new()
    {
        Name = "Streets",
        Description = "The streets of Night Soul City, baby!",
    };
    private readonly List<Place> _places = [];

    public void Generate(IList<Person> people)
    {
        foreach (var person in people)
        {
            var house = new Place
            {
                Name = $"{person.GetName()}'s House",
                Description = $"Nice apartment",
            };
            _places.Add(house);
            person._SetLocation(house);
            house._AddPerson(person);
        }
    }
}
