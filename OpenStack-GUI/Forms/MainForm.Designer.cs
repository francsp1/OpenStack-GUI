
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.ImageServiceTab = new System.Windows.Forms.TabPage();
            this.panelImageService = new System.Windows.Forms.Panel();
            this.volumesTab = new System.Windows.Forms.TabPage();
            this.panelVolumes = new System.Windows.Forms.Panel();
            this.instanceTab = new System.Windows.Forms.TabPage();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.btnLogout = new MaterialSkin.Controls.MaterialButton();
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.volumesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.ImageServiceTab);
            this.mainTabControl.Controls.Add(this.volumesTab);
            this.mainTabControl.Controls.Add(this.instanceTab);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabControlImageList;
            this.mainTabControl.Location = new System.Drawing.Point(2, 52);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
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
            this.ImageServiceTab.Controls.Add(this.panelImageService);
            this.ImageServiceTab.ImageKey = "image.png";
            this.ImageServiceTab.Location = new System.Drawing.Point(4, 39);
            this.ImageServiceTab.Margin = new System.Windows.Forms.Padding(2);
            this.ImageServiceTab.Name = "ImageServiceTab";
            this.ImageServiceTab.Padding = new System.Windows.Forms.Padding(2);
            this.ImageServiceTab.Size = new System.Drawing.Size(1155, 621);
            this.ImageServiceTab.TabIndex = 0;
            this.ImageServiceTab.Text = "Image Service";
            // 
            // panelImageService
            // 
            this.panelImageService.BackColor = System.Drawing.Color.White;
            this.panelImageService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageService.Location = new System.Drawing.Point(2, 2);
            this.panelImageService.Margin = new System.Windows.Forms.Padding(2);
            this.panelImageService.Name = "panelImageService";
            this.panelImageService.Size = new System.Drawing.Size(1151, 617);
            this.panelImageService.TabIndex = 0;
            // 
            // volumesTab
            // 
            this.volumesTab.BackColor = System.Drawing.Color.Transparent;
            this.volumesTab.Controls.Add(this.panelVolumes);
            this.volumesTab.ImageKey = "hard-drive.png";
            this.volumesTab.Location = new System.Drawing.Point(4, 39);
            this.volumesTab.Margin = new System.Windows.Forms.Padding(2);
            this.volumesTab.Name = "volumesTab";
            this.volumesTab.Padding = new System.Windows.Forms.Padding(2);
            this.volumesTab.Size = new System.Drawing.Size(1155, 621);
            this.volumesTab.TabIndex = 1;
            this.volumesTab.Text = "Volumes";
            // 
            // panelVolumes
            // 
            this.panelVolumes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVolumes.Location = new System.Drawing.Point(2, 2);
            this.panelVolumes.Name = "panelVolumes";
            this.panelVolumes.Size = new System.Drawing.Size(1151, 617);
            this.panelVolumes.TabIndex = 0;
            // 
            // instanceTab
            // 
            this.instanceTab.BackColor = System.Drawing.Color.White;
            this.instanceTab.ImageIndex = 3;
            this.instanceTab.Location = new System.Drawing.Point(4, 39);
            this.instanceTab.Name = "instanceTab";
            this.instanceTab.Size = new System.Drawing.Size(1155, 621);
            this.instanceTab.TabIndex = 2;
            this.instanceTab.Text = "Instances";
            // 
            // mainTabControlImageList
            // 
            this.mainTabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabControlImageList.ImageStream")));
            this.mainTabControlImageList.TransparentColor = System.Drawing.Color.White;
            this.mainTabControlImageList.Images.SetKeyName(0, "image.png");
            this.mainTabControlImageList.Images.SetKeyName(1, "database.png");
            this.mainTabControlImageList.Images.SetKeyName(2, "hard-drive.png");
            this.mainTabControlImageList.Images.SetKeyName(3, "data-server.png");
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
            this.comboBoxProjects.Location = new System.Drawing.Point(784, 32);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(192, 21);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogout.Depth = 0;
            this.btnLogout.HighEmphasis = true;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(1029, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogout.Size = new System.Drawing.Size(78, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "logout";
            this.btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogout.UseAccentColor = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.ImageServiceTab.ResumeLayout(false);
            this.volumesTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage ImageServiceTab;
        private System.Windows.Forms.TabPage volumesTab;
        private System.Windows.Forms.ImageList mainTabControlImageList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private System.Windows.Forms.Panel panelVolumes;
        private System.Windows.Forms.Panel panelImageService;
        private System.Windows.Forms.TabPage instanceTab;
    }
}