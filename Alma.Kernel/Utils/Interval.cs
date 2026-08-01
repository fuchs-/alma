namespace Alma.Kernel.Utils;

public enum IntervalType
{
    Empty,
    InclusiveInclusive,
    ExclusiveExclusive,
    ExclusiveInclusive,
    InclusiveExclusive,
}

public readonly record struct Interval(
    int Min = 0,
    int Max = 10,
    IntervalType Type = IntervalType.InclusiveExclusive
    )
{
    private static readonly Interval _empty = new(0, 0, IntervalType.Empty);
    public static Interval Empty => _empty;
}