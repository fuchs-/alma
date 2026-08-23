namespace Alma.Kernel.Observability;

public interface IPerson
{
    string GetName();
    int GetAge();

    INeeds GetNeeds();
}
