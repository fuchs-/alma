using Alma.Kernel.Observability;

namespace Alma.Kernel.World.People.Mind;

internal class LocationInformation(
    IPerson person,
    IPlace place,
    InformationConfidence confidence,
    DateTime timestamp
    )
    : Information(
        confidence,
        timestamp
    )
{
    public IPerson Person { get; } = person;
    public IPlace Place { get; } = place;
}
