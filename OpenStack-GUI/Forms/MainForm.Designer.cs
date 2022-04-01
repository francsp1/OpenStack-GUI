
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
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.collumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProtected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDiskFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createImageTab = new System.Windows.Forms.TabPage();
            this.switchProtected = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbBoxVisibility = new MaterialSkin.Controls.MaterialComboBox();
            this.lblVisibility = new MaterialSkin.Controls.MaterialLabel();
            this.txtMinimumRam = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMinimumDisk = new MaterialSkin.Controls.MaterialTextBox();
            this.lblMinimumRam = new MaterialSkin.Controls.MaterialLabel();
            this.lblMinimimDisk = new MaterialSkin.Controls.MaterialLabel();
            this.lblDiskFormat = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxDiskFormat = new MaterialSkin.Controls.MaterialComboBox();
            this.btnImageBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtImageFile = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageFile = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtImageDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.txtImageName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.logout = new MaterialSkin.Controls.MaterialButton();
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.imagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            this.createImageTab.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.createImageTab);
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
            this.collumnProjectId,
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
            // collumnProjectId
            // 
            this.collumnProjectId.HeaderText = "Project ID";
            this.collumnProjectId.MinimumWidth = 6;
            this.collumnProjectId.Name = "collumnProjectId";
            this.collumnProjectId.ReadOnly = true;
            this.collumnProjectId.Width = 250;
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
            this.collumnStatus.Width = 110;
            // 
            // collumnVisibility
            // 
            this.collumnVisibility.HeaderText = "Visibility";
            this.collumnVisibility.MinimumWidth = 6;
            this.collumnVisibility.Name = "collumnVisibility";
            this.collumnVisibility.ReadOnly = true;
            this.collumnVisibility.Width = 110;
            // 
            // collumnProtected
            // 
            this.collumnProtected.HeaderText = "Protected";
            this.collumnProtected.MinimumWidth = 6;
            this.collumnProtected.Name = "collumnProtected";
            this.collumnProtected.ReadOnly = true;
            this.collumnProtected.Width = 110;
            // 
            // collumnDiskFormat
            // 
            this.collumnDiskFormat.HeaderText = "Disk Format";
            this.collumnDiskFormat.MinimumWidth = 6;
            this.collumnDiskFormat.Name = "collumnDiskFormat";
            this.collumnDiskFormat.ReadOnly = true;
            this.collumnDiskFormat.Width = 110;
            // 
            // collumnSize
            // 
            this.collumnSize.HeaderText = "Size";
            this.collumnSize.MinimumWidth = 6;
            this.collumnSize.Name = "collumnSize";
            this.collumnSize.ReadOnly = true;
            this.collumnSize.Width = 110;
            // 
            // createImageTab
            // 
            this.createImageTab.BackColor = System.Drawing.Color.White;
            this.createImageTab.Controls.Add(this.switchProtected);
            this.createImageTab.Controls.Add(this.cmbBoxVisibility);
            this.createImageTab.Controls.Add(this.lblVisibility);
            this.createImageTab.Controls.Add(this.txtMinimumRam);
            this.createImageTab.Controls.Add(this.txtMinimumDisk);
            this.createImageTab.Controls.Add(this.lblMinimumRam);
            this.createImageTab.Controls.Add(this.lblMinimimDisk);
            this.createImageTab.Controls.Add(this.lblDiskFormat);
            this.createImageTab.Controls.Add(this.cmbBoxDiskFormat);
            this.createImageTab.Controls.Add(this.btnImageBrowse);
            this.createImageTab.Controls.Add(this.txtImageFile);
            this.createImageTab.Controls.Add(this.lblImageFile);
            this.createImageTab.Controls.Add(this.lblImageDescription);
            this.createImageTab.Controls.Add(this.txtImageDescription);
            this.createImageTab.Controls.Add(this.txtImageName);
            this.createImageTab.Controls.Add(this.lblImageName);
            this.createImageTab.Location = new System.Drawing.Point(4, 22);
            this.createImageTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createImageTab.Name = "createImageTab";
            this.createImageTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createImageTab.Size = new System.Drawing.Size(1144, 561);
            this.createImageTab.TabIndex = 1;
            this.createImageTab.Text = "Create Image";
            // 
            // switchProtected
            // 
            this.switchProtected.AutoSize = true;
            this.switchProtected.Depth = 0;
            this.switchProtected.Location = new System.Drawing.Point(252, 323);
            this.switchProtected.Margin = new System.Windows.Forms.Padding(0);
            this.switchProtected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchProtected.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchProtected.Name = "switchProtected";
            this.switchProtected.Ripple = true;
            this.switchProtected.Size = new System.Drawing.Size(125, 37);
            this.switchProtected.TabIndex = 16;
            this.switchProtected.Text = "Protected";
            this.switchProtected.UseVisualStyleBackColor = true;
            // 
            // cmbBoxVisibility
            // 
            this.cmbBoxVisibility.AutoResize = false;
            this.cmbBoxVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxVisibility.Depth = 0;
            this.cmbBoxVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxVisibility.DropDownHeight = 174;
            this.cmbBoxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxVisibility.DropDownWidth = 121;
            this.cmbBoxVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxVisibility.FormattingEnabled = true;
            this.cmbBoxVisibility.IntegralHeight = false;
            this.cmbBoxVisibility.ItemHeight = 43;
            this.cmbBoxVisibility.Items.AddRange(new object[] {
            "public",
            "private",
            "shared",
            "community"});
            this.cmbBoxVisibility.Location = new System.Drawing.Point(35, 313);
            this.cmbBoxVisibility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxVisibility.MaxDropDownItems = 4;
            this.cmbBoxVisibility.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxVisibility.Name = "cmbBoxVisibility";
            this.cmbBoxVisibility.Size = new System.Drawing.Size(140, 49);
            this.cmbBoxVisibility.StartIndex = 0;
            this.cmbBoxVisibility.TabIndex = 15;
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Depth = 0;
            this.lblVisibility.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVisibility.Location = new System.Drawing.Point(33, 295);
            this.lblVisibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisibility.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(61, 19);
            this.lblVisibility.TabIndex = 14;
            this.lblVisibility.Text = "Visibility";
            // 
            // txtMinimumRam
            // 
            this.txtMinimumRam.AnimateReadOnly = false;
            this.txtMinimumRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinimumRam.Depth = 0;
            this.txtMinimumRam.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinimumRam.LeadingIcon = null;
            this.txtMinimumRam.Location = new System.Drawing.Point(453, 219);
            this.txtMinimumRam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinimumRam.MaxLength = 50;
            this.txtMinimumRam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinimumRam.Multiline = false;
            this.txtMinimumRam.Name = "txtMinimumRam";
            this.txtMinimumRam.Size = new System.Drawing.Size(116, 50);
            this.txtMinimumRam.TabIndex = 13;
            this.txtMinimumRam.Text = "";
            this.txtMinimumRam.TrailingIcon = null;
            this.txtMinimumRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumRam_KeyPress);
            // 
            // txtMinimumDisk
            // 
            this.txtMinimumDisk.AnimateReadOnly = false;
            this.txtMinimumDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinimumDisk.Depth = 0;
            this.txtMinimumDisk.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMinimumDisk.LeadingIcon = null;
            this.txtMinimumDisk.Location = new System.Drawing.Point(252, 219);
            this.txtMinimumDisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMinimumDisk.MaxLength = 50;
            this.txtMinimumDisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinimumDisk.Multiline = false;
            this.txtMinimumDisk.Name = "txtMinimumDisk";
            this.txtMinimumDisk.Size = new System.Drawing.Size(116, 50);
            this.txtMinimumDisk.TabIndex = 12;
            this.txtMinimumDisk.Text = "";
            this.txtMinimumDisk.TrailingIcon = null;
            this.txtMinimumDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumDisk_KeyPress);
            // 
            // lblMinimumRam
            // 
            this.lblMinimumRam.AutoSize = true;
            this.lblMinimumRam.Depth = 0;
            this.lblMinimumRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinimumRam.Location = new System.Drawing.Point(451, 201);
            this.lblMinimumRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimumRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinimumRam.Name = "lblMinimumRam";
            this.lblMinimumRam.Size = new System.Drawing.Size(146, 19);
            this.lblMinimumRam.TabIndex = 11;
            this.lblMinimumRam.Text = "Minimum RAM (MB)";
            // 
            // lblMinimimDisk
            // 
            this.lblMinimimDisk.AutoSize = true;
            this.lblMinimimDisk.Depth = 0;
            this.lblMinimimDisk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMinimimDisk.Location = new System.Drawing.Point(250, 201);
            this.lblMinimimDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimimDisk.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMinimimDisk.Name = "lblMinimimDisk";
            this.lblMinimimDisk.Size = new System.Drawing.Size(140, 19);
            this.lblMinimimDisk.TabIndex = 10;
            this.lblMinimimDisk.Text = "Minimum Disk (GB)";
            // 
            // lblDiskFormat
            // 
            this.lblDiskFormat.AutoSize = true;
            this.lblDiskFormat.Depth = 0;
            this.lblDiskFormat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDiskFormat.Location = new System.Drawing.Point(33, 201);
            this.lblDiskFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiskFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDiskFormat.Name = "lblDiskFormat";
            this.lblDiskFormat.Size = new System.Drawing.Size(87, 19);
            this.lblDiskFormat.TabIndex = 9;
            this.lblDiskFormat.Text = "Disk Format";
            // 
            // cmbBoxDiskFormat
            // 
            this.cmbBoxDiskFormat.AutoResize = false;
            this.cmbBoxDiskFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxDiskFormat.Depth = 0;
            this.cmbBoxDiskFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxDiskFormat.DropDownHeight = 174;
            this.cmbBoxDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxDiskFormat.DropDownWidth = 121;
            this.cmbBoxDiskFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxDiskFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxDiskFormat.FormattingEnabled = true;
            this.cmbBoxDiskFormat.IntegralHeight = false;
            this.cmbBoxDiskFormat.ItemHeight = 43;
            this.cmbBoxDiskFormat.Items.AddRange(new object[] {
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
            "QCOW2",
            "VDI",
            "PLOOP",
            "ISO"});
            this.cmbBoxDiskFormat.Location = new System.Drawing.Point(35, 219);
            this.cmbBoxDiskFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBoxDiskFormat.MaxDropDownItems = 4;
            this.cmbBoxDiskFormat.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxDiskFormat.Name = "cmbBoxDiskFormat";
            this.cmbBoxDiskFormat.Size = new System.Drawing.Size(140, 49);
            this.cmbBoxDiskFormat.StartIndex = 0;
            this.cmbBoxDiskFormat.TabIndex = 8;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImageBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImageBrowse.Depth = 0;
            this.btnImageBrowse.HighEmphasis = true;
            this.btnImageBrowse.Icon = null;
            this.btnImageBrowse.Location = new System.Drawing.Point(704, 123);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnImageBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImageBrowse.Size = new System.Drawing.Size(80, 36);
            this.btnImageBrowse.TabIndex = 7;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImageBrowse.UseAccentColor = false;
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            // 
            // txtImageFile
            // 
            this.txtImageFile.AnimateReadOnly = false;
            this.txtImageFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageFile.Depth = 0;
            this.txtImageFile.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageFile.LeadingIcon = null;
            this.txtImageFile.Location = new System.Drawing.Point(35, 123);
            this.txtImageFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageFile.MaxLength = 260;
            this.txtImageFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageFile.Multiline = false;
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.Size = new System.Drawing.Size(655, 50);
            this.txtImageFile.TabIndex = 6;
            this.txtImageFile.Text = "";
            this.txtImageFile.TrailingIcon = null;
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Depth = 0;
            this.lblImageFile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageFile.Location = new System.Drawing.Point(33, 105);
            this.lblImageFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageFile.Name = "lblImageFile";
            this.lblImageFile.Size = new System.Drawing.Size(138, 19);
            this.lblImageFile.TabIndex = 5;
            this.lblImageFile.Text = "Image Source (File)";
            // 
            // lblImageDescription
            // 
            this.lblImageDescription.AutoSize = true;
            this.lblImageDescription.Depth = 0;
            this.lblImageDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageDescription.Location = new System.Drawing.Point(434, 11);
            this.lblImageDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageDescription.Name = "lblImageDescription";
            this.lblImageDescription.Size = new System.Drawing.Size(129, 19);
            this.lblImageDescription.TabIndex = 4;
            this.lblImageDescription.Text = "Image Description";
            // 
            // txtImageDescription
            // 
            this.txtImageDescription.AnimateReadOnly = false;
            this.txtImageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageDescription.Depth = 0;
            this.txtImageDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageDescription.LeadingIcon = null;
            this.txtImageDescription.Location = new System.Drawing.Point(436, 28);
            this.txtImageDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageDescription.MaxLength = 200;
            this.txtImageDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageDescription.Multiline = false;
            this.txtImageDescription.Name = "txtImageDescription";
            this.txtImageDescription.Size = new System.Drawing.Size(560, 50);
            this.txtImageDescription.TabIndex = 3;
            this.txtImageDescription.Text = "";
            this.txtImageDescription.TrailingIcon = null;
            // 
            // txtImageName
            // 
            this.txtImageName.AnimateReadOnly = false;
            this.txtImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageName.Depth = 0;
            this.txtImageName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageName.LeadingIcon = null;
            this.txtImageName.Location = new System.Drawing.Point(35, 28);
            this.txtImageName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageName.MaxLength = 50;
            this.txtImageName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageName.Multiline = false;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(316, 50);
            this.txtImageName.TabIndex = 2;
            this.txtImageName.Text = "";
            this.txtImageName.TrailingIcon = null;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Depth = 0;
            this.lblImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageName.Location = new System.Drawing.Point(33, 11);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(91, 19);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image Name";
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
            this.comboBoxProjects.Location = new System.Drawing.Point(784, 32);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(192, 21);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logout.Depth = 0;
            this.logout.HighEmphasis = true;
            this.logout.Icon = null;
            this.logout.Location = new System.Drawing.Point(1029, 13);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.logout.Name = "logout";
            this.logout.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logout.Size = new System.Drawing.Size(78, 36);
            this.logout.TabIndex = 2;
            this.logout.Text = "logout";
            this.logout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logout.UseAccentColor = false;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.logout);
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
            this.createImageTab.ResumeLayout(false);
            this.createImageTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage ImageServiceTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList mainTabControlImageList;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage imagesTab;
        private System.Windows.Forms.TabPage createImageTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProtected;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDiskFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnSize;
        private MaterialSkin.Controls.MaterialLabel lblImageDescription;
        private MaterialSkin.Controls.MaterialTextBox txtImageDescription;
        private MaterialSkin.Controls.MaterialTextBox txtImageName;
        private MaterialSkin.Controls.MaterialLabel lblImageName;
        private MaterialSkin.Controls.MaterialTextBox txtImageFile;
        private MaterialSkin.Controls.MaterialLabel lblImageFile;
        private MaterialSkin.Controls.MaterialButton btnImageBrowse;
        private MaterialSkin.Controls.MaterialLabel lblDiskFormat;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxDiskFormat;
        private MaterialSkin.Controls.MaterialTextBox txtMinimumRam;
        private MaterialSkin.Controls.MaterialTextBox txtMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblMinimumRam;
        private MaterialSkin.Controls.MaterialLabel lblMinimimDisk;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxVisibility;
        private MaterialSkin.Controls.MaterialLabel lblVisibility;
        private MaterialSkin.Controls.MaterialSwitch switchProtected;
        private MaterialSkin.Controls.MaterialButton logout;
    }
}