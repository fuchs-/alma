namespace Alma.Kernel.Model;

internal class Place
{
    public required string Name { get; init; }
    public string Description { get; init; } = string.Empty;
    private HashSet<Person> _people = new();

    public void _AddPerson(Person person)
    {
        if (_people.Contains(person))
            throw new ArgumentException(
                $"Trying to add Person {person} to Place {this}, but they're already there",
                nameof(person)
                );

        _people.Add(person);
    }

    public void _RemovePerson(Person person)
    {
        if (!_people.Contains(person))
            throw new ArgumentException(
                $"Trying to remove Person {person} from Place {this}, but they're not there",
                nameof(person)
                );
        _people.Remove(person);
    }

    public override string ToString()
    {
        return Name;
    }
}
