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

        protected override bool CanShowMenu()
        {
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            var contextMenu = new ContextMenuStrip();
            var mnuFolderReclaimer = new ToolStripMenuItem { Text = "Folder Reclaimer" };
            var itemMoveAndHideFolder = new ToolStripMenuItem { Text = "Move && Hide Folder" };
            var itemHideFolder = new ToolStripMenuItem { Text = "Hide Folder" };

            itemMoveAndHideFolder.Click += (sender, args) => MoveAndHide();
            itemHideFolder.Click += (sender, args) => HideFolder();
            mnuFolderReclaimer.DropDownItems.AddRange(new ToolStripItem[] { itemMoveAndHideFolder, itemHideFolder });
            contextMenu.Items.Add(mnuFolderReclaimer);

            return contextMenu;
        }

        private void HideFolder()
        {
            return;
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
