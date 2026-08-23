using Alma.Kernel.Observability;

namespace Alma.Kernel.Sim;

partial class Simulation : ISimulation
{
    public IReadOnlyList<IPerson> GetAllPeople() => _people;

    public event EventHandler? TickEnded;
}
