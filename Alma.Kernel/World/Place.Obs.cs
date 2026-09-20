using Alma.Kernel.Observability;

namespace Alma.Kernel.World;

partial class Place : IPlace
{
    public void Enter(IPerson person)
    {
        if (!_occupants.Add(person))
            return;

        foreach (var occupant in _occupants)
        {
            if (occupant != person)
                occupant.OnPersonEntered(person);
        }
    }
}
