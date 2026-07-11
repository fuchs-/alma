namespace Alma.Kernel.Utils;

internal class RNG
{
    private readonly Random _random;

    public RNG(int? seed = null)
    {
        _random = seed.HasValue
            ? new Random(seed.Value)
            : new Random();
    }

    public int Generate(int max = 10, int min = 0)
    {
        return _random.Next(min, max);
    }

    public int GeneratePercentage()
    {
        return _random.Next(0, 101);
    }


    public T ChooseFrom<T>(T[] items)
    {
        return items[Generate(items.Length)];
    }
}
