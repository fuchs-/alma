namespace Alma.Kernel.Model;

internal class World
{
    private readonly List<Place> _places = new();
    private readonly List<Person> _people = new();

    public void Move(Person person, Place place)
    {
        Place previous = person.Location
            ?? throw new InvalidOperationException(
                $"Trying to move Person {person} but it has no current location.");

        if (place == previous)
            throw new InvalidOperationException(
                $"Trying to move Person {person} to Place {place} but they're already there");

        previous._RemovePerson(person);
        place._AddPerson(person);

        person._SetLocation(place);
    }
}
