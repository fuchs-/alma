using Alma.Kernel.People;

namespace Alma.Kernel.Debugger.Controls;

partial class PersonViewer
{
    private TableLayoutPanel _layout;
    private Label _titleLabel;
    private Label _nameLabel;

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

        _layout.Controls.Add(_titleLabel);
        _layout.Controls.Add(_nameLabel);

        Controls.Add(_layout);
    }
}
