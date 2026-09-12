namespace Alma.Kernel.Observability.Debug;

public interface IDebugPerson
{
    string GetName();
    int GetAge();

    IDebugNeeds GetNeeds();
    string GetCurrentActivity();
}
