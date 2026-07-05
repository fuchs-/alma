namespace Alma.Kernel.Model;

internal class Person
{
    public required PersonIdentity Identity { get; init; }
    public Place? Location { get; private set; }

    public void _SetLocation(Place place)
    {
        Location = place;
    }

    public override string ToString()
    {
        return Identity.Name;
    }
}
