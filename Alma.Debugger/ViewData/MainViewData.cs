using Alma.Debugger.ViewModels;
using Alma.Kernel.Observability.Debug;

namespace Alma.Debugger.ViewData;

public class MainViewData(DebugSimulationContext context)
{
    public IReadOnlyList<PersonViewModel> People { get; } 
        = context.People
            .Select(p => new PersonViewModel(p))
            .ToList();
}
