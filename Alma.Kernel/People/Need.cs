using Alma.Kernel.Utils;

namespace Alma.Kernel.People;

internal class Need(int initialValue = 0, int threshold = 85)
{
    private readonly int _threshold = threshold;

    public int CurrentValue { get; private set; } = initialValue;
    public bool IsUrgent => CurrentValue > _threshold;

    public void Increase(int amount)
    {
        CurrentValue += amount;

        if (CurrentValue > 100)
            CurrentValue = 100;
    }

    public void Decrease(int amount)
    {
        CurrentValue -= amount;

        if (CurrentValue < 0)
            CurrentValue = 0;
    }

    public void Satisfy(RNG rng) => Decrease(rng.Generate(10, 25));
}
