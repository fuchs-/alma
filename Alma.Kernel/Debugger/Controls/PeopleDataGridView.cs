using Alma.Kernel.Debugger.Framework;
using Alma.Kernel.Debugger.ViewModels;
using Alma.Kernel.Observability.Debug;

namespace Alma.Kernel.Debugger.Controls;

internal class PeopleDataGridView : DataGridView, IADControl
{
    private readonly BindingSource _bindingSource = [];
    public PeopleDataGridView()
    {
        DoubleBuffered = true;
        AutoGenerateColumns = false;
        AllowUserToAddRows = false;

        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ReadOnly = true;

        CreateColumns();

        DataSource = _bindingSource;
    }

    private void CreateColumns()
    {
        AddColumn("Name", nameof(PersonViewModel.Name));
        AddColumn("Age", nameof(PersonViewModel.Age));
        AddColumn("Tension", nameof(PersonViewModel.Tension));
        AddColumn("Activity", nameof(PersonViewModel.Activity));
    }

    private void AddColumn(string header, string dataProperty)
    {
        var column = new DataGridViewTextBoxColumn();
        column.HeaderText = header;
        column.DataPropertyName = dataProperty;
        Columns.Add(column);
    }

    public void SetData(IEnumerable<IDebugPerson> people)
    {

        _bindingSource.DataSource = people
            .Select(p => new PersonViewModel(p))
            .ToArray();
    }

    public void RefreshUI()
    {
        _bindingSource.ResetBindings(false);
    }
}
