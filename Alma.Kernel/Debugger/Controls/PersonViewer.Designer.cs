using Alma.Kernel.World.People;

namespace Alma.Kernel.Debugger.Controls;

partial class PersonViewer
{
    private TableLayoutPanel _layout;
    private Label _titleLabel;
    private Label _nameLabel;
    private Label _tensionLabel;
    private Label _activityLabel;

    protected override void BuildView()
    {
        _layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 0,
            BackColor = Color.DarkGray,
        };

        _titleLabel = new Label
        {
            AutoSize = true,
            Text = "Person",
            Font = new Font("Segoe UI", 18),
        };
        _nameLabel = new Label
        {
            AutoSize = true,
            Text = "Name",
        };
        _tensionLabel = new Label
        {
            AutoSize = true,
            Text = "Tension",
        };
        _activityLabel = new Label
        {
            AutoSize = true,
            Text = "Activity",
        };

        _layout.Controls.AddRange([
            _titleLabel,
            _nameLabel,
            _tensionLabel,
            _activityLabel,
            ]);

        Controls.Add(_layout);
    }
}
