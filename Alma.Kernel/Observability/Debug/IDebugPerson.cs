namespace Alma.Kernel.Observability.Debug;

public interface IDebugPerson : IPersonBase
{
    int GetAge();

    IDebugNeeds GetNeeds();
    string GetCurrentActivity();
}
