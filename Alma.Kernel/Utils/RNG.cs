namespace Alma.Kernel.Utils;



internal class RNG
{
    private readonly int? _seed;
    private readonly Random _random;
    private Interval _defaultInterval;

    public RNG(int? seed = null, Interval? defaultInterval = null)
    {
        _seed = seed;

        _random = _seed.HasValue
            ? new Random(_seed.Value)
            : new Random();

        _defaultInterval = defaultInterval ?? new();
    }

    public int GenerateWithInterval(Interval? interval = null)
    {
        var currentInterval = interval ?? _defaultInterval;

        var min = currentInterval.Min;
        var max = currentInterval.Max;

        return currentInterval.Type switch
        {
            IntervalType.InclusiveInclusive => _random.Next(min, max + 1),
            IntervalType.ExclusiveExclusive => _random.Next(min + 1, max),
            IntervalType.ExclusiveInclusive => _random.Next(min + 1, max + 1),
            IntervalType.InclusiveExclusive => _random.Next(min, max),
            _ => throw new ArgumentOutOfRangeException(
                nameof(currentInterval.Type),
                currentInterval.Type, null),
        };
    }

    /// <summary>
    /// Generates a non-negative number, lower than max
    /// </summary>
    /// <param name="max">Exclusive upper bound</param>
    public int Generate(int max)
    {
        return _random.Next(max);
    }

    /// <summary>
    /// Generates a random number inside the range [min, max)
    /// </summary>
    /// <param name="min">Inclusive lower bound</param>
    /// <param name="max">Exclusive upper bound</param>
    public int Generate(int min, int max)
    {
        return _random.Next(min, max);
    }

    public int GeneratePercentage()
    {
        return _random.Next(0, 101);
    }


    public T ChooseFrom<T>(T[] items)
    {
        return items[_random.Next(items.Length)];
    }
}
