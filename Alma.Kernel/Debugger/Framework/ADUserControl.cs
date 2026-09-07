namespace Alma.Kernel.Debugger.Framework;

internal class ADUserControl : UserControl
{
    public ADUserControl()
    {
        BuildView();
        RefreshUI();
    }

    protected virtual void BuildView() { }

    public virtual void RefreshUI(bool recursive = true)
    {
        if (recursive)
            ADHelper.RefreshUIRecursive(Controls);
    }
}
