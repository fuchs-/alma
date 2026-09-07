using static System.Windows.Forms.Control;

namespace Alma.Kernel.Debugger.Framework;

internal static class ADHelper
{
    public static void RefreshUIRecursive(ControlCollection controls)
    {
        foreach (Control c in controls)
        {
            _RefreshUIRecursive(c);
        }
    }

    private static void _RefreshUIRecursive(Control c)
    {
        switch (c)
        {
            case ADUserControl adUserControl:
                adUserControl.RefreshUI(true);
                break;
            case IADControl adControl:
                adControl.RefreshUI();
                break;
            default:
                RefreshUIRecursive(c.Controls);
                break;
        }
    }
}
