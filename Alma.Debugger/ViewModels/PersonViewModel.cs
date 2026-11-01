using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Alma.Kernel.Observability.Debug;

namespace Alma.Debugger.ViewModels;

public class PersonViewModel(IDebugPerson person) 
    : INotifyPropertyChanged
{
    private readonly IDebugPerson _person = person;

    public string Name => _person.GetName();
    public int Age => _person.GetAge();
    public int Tension => _person.GetNeeds().GetTension();
    public string Activity => _person.GetCurrentActivity();
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void Refresh()
    {
        OnPropertyChanged(nameof(Name));
        OnPropertyChanged(nameof(Age));
        OnPropertyChanged(nameof(Tension));
        OnPropertyChanged(nameof(Activity));
    }
}