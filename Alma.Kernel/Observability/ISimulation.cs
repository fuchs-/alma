namespace Alma.Kernel.Observability;

public interface ISimulation
{
    IReadOnlyList<IPerson> GetAllPeople();
    event EventHandler? TickEnded;
}
