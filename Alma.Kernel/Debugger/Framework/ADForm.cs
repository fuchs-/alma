namespace Alma.Kernel.Debugger.Framework;

internal class ADForm : Form
{
    public ADForm() => BuildView();

    protected virtual void BuildView() { }



    protected virtual void RefreshUI(bool recursive = true)
    {
        if (recursive)
            ADHelper.RefreshUIRecursive(Controls);
    }
}
