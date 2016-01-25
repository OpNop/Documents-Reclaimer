using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using System.Linq;

namespace Documents_Reclaimer
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.Directory)]
    public class Documents_Reclaimer_Extension : SharpContextMenu
    {

        [DllImport("kernel32.dll")]
        static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);
        enum SymbolicLink
        {
            File = 0,
            Directory = 1
        }

        protected override bool CanShowMenu()
        {
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            var menu = new ContextMenuStrip();
            var itemMoveAndHideFolder = new ToolStripMenuItem { Text = "Move && Hide Folder" };

            itemMoveAndHideFolder.Click += (sender, args) => MoveAndHide();
            menu.Items.Add(itemMoveAndHideFolder);

            return menu;
        }

        private void MoveAndHide()
        {
            var directory = SelectedItemPaths.FirstOrDefault();
            var frm = new frmMain(directory);
            frm.ShowDialog();
            //MessageBox.Show("Hello from Documents Reclaimer");
        }

    }
}
