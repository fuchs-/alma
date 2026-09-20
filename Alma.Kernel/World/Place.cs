using Alma.Kernel.Observability;

namespace Alma.Kernel.World;

internal partial class Place
{
    public required string Name { get; init; }
    public string Description { get; init; } = string.Empty;
    private HashSet<IPerson> _occupants = new();

    public void _InitializeOccupant(IPerson person)
    {
        _occupants.Add(person);
    }

    public override string ToString()
    {
        return Name;
    }
}
