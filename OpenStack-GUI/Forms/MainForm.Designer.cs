
namespace OpenStack_GUI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ImageServiceTab = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.imagesTab = new System.Windows.Forms.TabPage();
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.collumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProtected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDiskFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.imagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ImageServiceTab);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabControlImageList;
            this.mainTabControl.Location = new System.Drawing.Point(2, 52);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1163, 664);
            this.mainTabControl.TabIndex = 0;
            // 
            // ImageServiceTab
            // 
            this.ImageServiceTab.BackColor = System.Drawing.Color.White;
            this.ImageServiceTab.Controls.Add(this.materialTabControl1);
            this.ImageServiceTab.Controls.Add(this.materialTabSelector1);
            this.ImageServiceTab.Location = new System.Drawing.Point(4, 39);
            this.ImageServiceTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageServiceTab.Name = "ImageServiceTab";
            this.ImageServiceTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageServiceTab.Size = new System.Drawing.Size(1155, 621);
            this.ImageServiceTab.TabIndex = 0;
            this.ImageServiceTab.Text = "Image Service";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.imagesTab);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 41);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1151, 578);
            this.materialTabControl1.TabIndex = 1;
            // 
            // imagesTab
            // 
            this.imagesTab.BackColor = System.Drawing.Color.White;
            this.imagesTab.Controls.Add(this.imagesDataGridView);
            this.imagesTab.Location = new System.Drawing.Point(4, 22);
            this.imagesTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagesTab.Size = new System.Drawing.Size(1143, 552);
            this.imagesTab.TabIndex = 0;
            this.imagesTab.Text = "Images";
            // 
            // imagesDataGridView
            // 
            this.imagesDataGridView.AllowUserToAddRows = false;
            this.imagesDataGridView.AllowUserToDeleteRows = false;
            this.imagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.imagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.collumnID,
            this.collumnOwner,
            this.collumnName,
            this.collumnStatus,
            this.collumnVisibility,
            this.collumnProtected,
            this.collumnDiskFormat,
            this.collumnSize});
            this.imagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesDataGridView.GridColor = System.Drawing.Color.White;
            this.imagesDataGridView.Location = new System.Drawing.Point(2, 2);
            this.imagesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.RowHeadersWidth = 51;
            this.imagesDataGridView.RowTemplate.Height = 24;
            this.imagesDataGridView.Size = new System.Drawing.Size(1139, 548);
            this.imagesDataGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(1144, 561);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(2, 2);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1151, 39);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1154, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tab 2";
            // 
            // mainTabControlImageList
            // 
            this.mainTabControlImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainTabControlImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.mainTabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(762, 27);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(192, 21);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 40;
            // 
            // collumnID
            // 
            this.collumnID.HeaderText = "ID";
            this.collumnID.MinimumWidth = 6;
            this.collumnID.Name = "collumnID";
            this.collumnID.Visible = false;
            this.collumnID.Width = 6;
            // 
            // collumnOwner
            // 
            this.collumnOwner.HeaderText = "Owner";
            this.collumnOwner.MinimumWidth = 6;
            this.collumnOwner.Name = "collumnOwner";
            this.collumnOwner.ReadOnly = true;
            this.collumnOwner.Width = 200;
            // 
            // collumnName
            // 
            this.collumnName.HeaderText = "Name";
            this.collumnName.MinimumWidth = 6;
            this.collumnName.Name = "collumnName";
            this.collumnName.ReadOnly = true;
            this.collumnName.Width = 200;
            // 
            // collumnStatus
            // 
            this.collumnStatus.HeaderText = "Status";
            this.collumnStatus.MinimumWidth = 6;
            this.collumnStatus.Name = "collumnStatus";
            this.collumnStatus.ReadOnly = true;
            this.collumnStatus.Width = 120;
            // 
            // collumnVisibility
            // 
            this.collumnVisibility.HeaderText = "Visibility";
            this.collumnVisibility.MinimumWidth = 6;
            this.collumnVisibility.Name = "collumnVisibility";
            this.collumnVisibility.ReadOnly = true;
            this.collumnVisibility.Width = 120;
            // 
            // collumnProtected
            // 
            this.collumnProtected.HeaderText = "Protected";
            this.collumnProtected.MinimumWidth = 6;
            this.collumnProtected.Name = "collumnProtected";
            this.collumnProtected.ReadOnly = true;
            this.collumnProtected.Width = 120;
            // 
            // collumnDiskFormat
            // 
            this.collumnDiskFormat.HeaderText = "Disk Format";
            this.collumnDiskFormat.MinimumWidth = 6;
            this.collumnDiskFormat.Name = "collumnDiskFormat";
            this.collumnDiskFormat.ReadOnly = true;
            this.collumnDiskFormat.Width = 120;
            // 
            // collumnSize
            // 
            this.collumnSize.HeaderText = "Size";
            this.collumnSize.MinimumWidth = 6;
            this.collumnSize.Name = "collumnSize";
            this.collumnSize.ReadOnly = true;
            this.collumnSize.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.ImageServiceTab.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.imagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage ImageServiceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList mainTabControlImageList;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage imagesTab;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProtected;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDiskFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnSize;
    }
}