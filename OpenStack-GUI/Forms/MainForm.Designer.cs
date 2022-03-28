
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
            this.imagesListView = new MaterialSkin.Controls.MaterialListView();
            this.columnChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVisibility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProtected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDiskFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.columnOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.imagesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ImageServiceTab);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabControlImageList;
            this.mainTabControl.Location = new System.Drawing.Point(3, 64);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1594, 833);
            this.mainTabControl.TabIndex = 0;
            // 
            // ImageServiceTab
            // 
            this.ImageServiceTab.BackColor = System.Drawing.Color.White;
            this.ImageServiceTab.Controls.Add(this.materialTabControl1);
            this.ImageServiceTab.Controls.Add(this.materialTabSelector1);
            this.ImageServiceTab.Location = new System.Drawing.Point(4, 39);
            this.ImageServiceTab.Name = "ImageServiceTab";
            this.ImageServiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImageServiceTab.Size = new System.Drawing.Size(1586, 790);
            this.ImageServiceTab.TabIndex = 0;
            this.ImageServiceTab.Text = "Image Service";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.imagesTab);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 51);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1580, 736);
            this.materialTabControl1.TabIndex = 1;
            // 
            // imagesTab
            // 
            this.imagesTab.BackColor = System.Drawing.Color.White;
            this.imagesTab.Controls.Add(this.imagesListView);
            this.imagesTab.Location = new System.Drawing.Point(4, 25);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.imagesTab.Size = new System.Drawing.Size(1572, 707);
            this.imagesTab.TabIndex = 0;
            this.imagesTab.Text = "Images";
            // 
            // imagesListView
            // 
            this.imagesListView.AutoSizeTable = false;
            this.imagesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnChecked,
            this.columnOwner,
            this.columnName,
            this.columnSatus,
            this.columnVisibility,
            this.columnProtected,
            this.columnDiskFormat,
            this.columnSize});
            this.imagesListView.Depth = 0;
            this.imagesListView.FullRowSelect = true;
            this.imagesListView.HideSelection = false;
            this.imagesListView.Location = new System.Drawing.Point(27, 58);
            this.imagesListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.imagesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.imagesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.OwnerDraw = true;
            this.imagesListView.Size = new System.Drawing.Size(1255, 626);
            this.imagesListView.TabIndex = 0;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            this.imagesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnChecked
            // 
            this.columnChecked.Text = "";
            // 
            // columnName
            // 
            this.columnName.DisplayIndex = 1;
            this.columnName.Text = "Name";
            this.columnName.Width = 250;
            // 
            // columnVisibility
            // 
            this.columnVisibility.DisplayIndex = 2;
            this.columnVisibility.Text = "Visibility";
            this.columnVisibility.Width = 100;
            // 
            // columnProtected
            // 
            this.columnProtected.DisplayIndex = 3;
            this.columnProtected.Text = "Protected";
            this.columnProtected.Width = 100;
            // 
            // columnDiskFormat
            // 
            this.columnDiskFormat.DisplayIndex = 4;
            this.columnDiskFormat.Text = "Disk Format";
            this.columnDiskFormat.Width = 120;
            // 
            // columnSize
            // 
            this.columnSize.DisplayIndex = 5;
            this.columnSize.Text = "Size";
            this.columnSize.Width = 100;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1572, 707);
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
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1580, 48);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1586, 790);
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
            this.comboBoxProjects.Location = new System.Drawing.Point(1041, 34);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(255, 24);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // columnOwner
            // 
            this.columnOwner.Text = "Owner";
            this.columnOwner.Width = 100;
            // 
            // columnSatus
            // 
            this.columnSatus.Text = "Status";
            this.columnSatus.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.ImageServiceTab.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.imagesTab.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialListView imagesListView;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnVisibility;
        private System.Windows.Forms.ColumnHeader columnProtected;
        private System.Windows.Forms.ColumnHeader columnDiskFormat;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnChecked;
        private System.Windows.Forms.ColumnHeader columnOwner;
        private System.Windows.Forms.ColumnHeader columnSatus;
    }
}