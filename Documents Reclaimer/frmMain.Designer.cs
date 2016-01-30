namespace Documents_Reclaimer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbFolderIcon = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFolderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFolderIcon
            // 
            this.pbFolderIcon.Location = new System.Drawing.Point(12, 12);
            this.pbFolderIcon.Name = "pbFolderIcon";
            this.pbFolderIcon.Size = new System.Drawing.Size(32, 32);
            this.pbFolderIcon.TabIndex = 0;
            this.pbFolderIcon.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(50, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(288, 57);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(50, 88);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(288, 44);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "You can change where files in this folder are stored to another place on this har" +
    "d drive , another drive, or another computer on your network.";
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(53, 161);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore Defualt";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(150, 161);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(91, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move ...";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(247, 161);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(91, 23);
            this.btnFindTarget.TabIndex = 3;
            this.btnFindTarget.Text = "Find Target";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(53, 135);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(285, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(182, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(263, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 283);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pbFolderIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Reclaim this Folder";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFolderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFolderIcon;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}