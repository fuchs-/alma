namespace Alma.Kernel.Model.People;

internal class Needs
{
    public Need Socialize { get; } = new Need(50);
}

internal class Need(int value = 0)
{
    private int _value = value;
    public int Value
    {
        get => _value;
    }

    public void Increase(int amount)
    {
        _value += amount;

        if (_value > 100)
            _value = 100;
    }

    public void Decrease(int amount)
    {
        _value -= amount;

        if (_value < 0)
            _value = 0;
    }
}
