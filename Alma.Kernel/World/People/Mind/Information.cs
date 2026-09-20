namespace Alma.Kernel.World.People.Mind;

internal class Information(
    InformationConfidence confidence,
    DateTime timestamp
    )
{
    public InformationConfidence Confidence { get; } = confidence;
    public DateTime Timestamp { get; } = timestamp;
}
