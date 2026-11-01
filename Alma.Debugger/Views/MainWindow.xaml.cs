using System.Windows;
using Alma.Debugger.ViewData;

namespace Alma.Debugger.Views;

public partial class MainWindow : Window
{
    private readonly SimulationRunner _simulationRunner = new();
    
    public MainWindow()
    {
        InitializeComponent();
        
        DataContext = new MainViewData(
                _simulationRunner.GetContext()
            );
    }

    private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        try
        {
            await _simulationRunner.Run(CancellationToken.None);
        }
        catch
        {
            return;
        }
    }
}
