using Alma.Debugger.ViewModels;
using Alma.Kernel.Observability.Debug;

namespace Alma.Debugger.ViewData;

public class MainViewData
{
    private readonly DebugSimulationContext _context;
    public IReadOnlyList<PersonViewModel> People { get; }

    public MainViewData(DebugSimulationContext context)
    {
        _context = context;
        
        People = context.People
            .Select(p => new PersonViewModel(p))
            .ToList();

        context.TickEnded += Refresh;
    }

    private void Refresh()
    {
        foreach (var person in People)
            person.Refresh();
    }
}
