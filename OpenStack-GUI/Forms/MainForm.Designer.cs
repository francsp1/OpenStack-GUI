
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
            this.imagesTabControl = new MaterialSkin.Controls.MaterialTabControl();
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
            this.switchImageProtected = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbImageBoxVisibility = new MaterialSkin.Controls.MaterialComboBox();
            this.lblImageVisibility = new MaterialSkin.Controls.MaterialLabel();
            this.txtImageMinimumRam = new MaterialSkin.Controls.MaterialTextBox();
            this.txtImageMinimumDisk = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageMinimumRam = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageMinimimDisk = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageDiskFormat = new MaterialSkin.Controls.MaterialLabel();
            this.cmbBoxImageDiskFormat = new MaterialSkin.Controls.MaterialComboBox();
            this.btnImageBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtImageFile = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageFile = new MaterialSkin.Controls.MaterialLabel();
            this.lblImageDescription = new MaterialSkin.Controls.MaterialLabel();
            this.txtImageDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.txtImageName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageName = new MaterialSkin.Controls.MaterialLabel();
            this.imagesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.logout = new MaterialSkin.Controls.MaterialButton();
            this.mainTabControl.SuspendLayout();
            this.ImageServiceTab.SuspendLayout();
            this.imagesTabControl.SuspendLayout();
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
            this.mainTabControl.Location = new System.Drawing.Point(3, 64);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1550, 818);
            this.mainTabControl.TabIndex = 0;
            // 
            // ImageServiceTab
            // 
            this.ImageServiceTab.BackColor = System.Drawing.Color.White;
            this.ImageServiceTab.Controls.Add(this.imagesTabControl);
            this.ImageServiceTab.Controls.Add(this.imagesTabSelector);
            this.ImageServiceTab.Location = new System.Drawing.Point(4, 39);
            this.ImageServiceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageServiceTab.Name = "ImageServiceTab";
            this.ImageServiceTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageServiceTab.Size = new System.Drawing.Size(1542, 775);
            this.ImageServiceTab.TabIndex = 0;
            this.ImageServiceTab.Text = "Image Service";
            // 
            // imagesTabControl
            // 
            this.imagesTabControl.Controls.Add(this.imagesTab);
            this.imagesTabControl.Controls.Add(this.createImageTab);
            this.imagesTabControl.Depth = 0;
            this.imagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTabControl.Location = new System.Drawing.Point(3, 50);
            this.imagesTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabControl.Multiline = true;
            this.imagesTabControl.Name = "imagesTabControl";
            this.imagesTabControl.SelectedIndex = 0;
            this.imagesTabControl.Size = new System.Drawing.Size(1536, 723);
            this.imagesTabControl.TabIndex = 1;
            // 
            // imagesTab
            // 
            this.imagesTab.BackColor = System.Drawing.Color.White;
            this.imagesTab.Controls.Add(this.imagesDataGridView);
            this.imagesTab.Location = new System.Drawing.Point(4, 25);
            this.imagesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTab.Size = new System.Drawing.Size(1528, 694);
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
            this.imagesDataGridView.Location = new System.Drawing.Point(3, 2);
            this.imagesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.RowHeadersWidth = 51;
            this.imagesDataGridView.RowTemplate.Height = 24;
            this.imagesDataGridView.Size = new System.Drawing.Size(1522, 690);
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
            this.createImageTab.Controls.Add(this.switchImageProtected);
            this.createImageTab.Controls.Add(this.cmbImageBoxVisibility);
            this.createImageTab.Controls.Add(this.lblImageVisibility);
            this.createImageTab.Controls.Add(this.txtImageMinimumRam);
            this.createImageTab.Controls.Add(this.txtImageMinimumDisk);
            this.createImageTab.Controls.Add(this.lblImageMinimumRam);
            this.createImageTab.Controls.Add(this.lblImageMinimimDisk);
            this.createImageTab.Controls.Add(this.lblImageDiskFormat);
            this.createImageTab.Controls.Add(this.cmbBoxImageDiskFormat);
            this.createImageTab.Controls.Add(this.btnImageBrowse);
            this.createImageTab.Controls.Add(this.txtImageFile);
            this.createImageTab.Controls.Add(this.lblImageFile);
            this.createImageTab.Controls.Add(this.lblImageDescription);
            this.createImageTab.Controls.Add(this.txtImageDescription);
            this.createImageTab.Controls.Add(this.txtImageName);
            this.createImageTab.Controls.Add(this.lblImageName);
            this.createImageTab.Location = new System.Drawing.Point(4, 25);
            this.createImageTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createImageTab.Name = "createImageTab";
            this.createImageTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createImageTab.Size = new System.Drawing.Size(1528, 694);
            this.createImageTab.TabIndex = 1;
            this.createImageTab.Text = "Create Image";
            // 
            // switchImageProtected
            // 
            this.switchImageProtected.AutoSize = true;
            this.switchImageProtected.Depth = 0;
            this.switchImageProtected.Location = new System.Drawing.Point(336, 398);
            this.switchImageProtected.Margin = new System.Windows.Forms.Padding(0);
            this.switchImageProtected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchImageProtected.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchImageProtected.Name = "switchImageProtected";
            this.switchImageProtected.Ripple = true;
            this.switchImageProtected.Size = new System.Drawing.Size(125, 37);
            this.switchImageProtected.TabIndex = 16;
            this.switchImageProtected.Text = "Protected";
            this.switchImageProtected.UseVisualStyleBackColor = true;
            // 
            // cmbImageBoxVisibility
            // 
            this.cmbImageBoxVisibility.AutoResize = false;
            this.cmbImageBoxVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbImageBoxVisibility.Depth = 0;
            this.cmbImageBoxVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbImageBoxVisibility.DropDownHeight = 174;
            this.cmbImageBoxVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageBoxVisibility.DropDownWidth = 121;
            this.cmbImageBoxVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbImageBoxVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbImageBoxVisibility.FormattingEnabled = true;
            this.cmbImageBoxVisibility.IntegralHeight = false;
            this.cmbImageBoxVisibility.ItemHeight = 43;
            this.cmbImageBoxVisibility.Items.AddRange(new object[] {
            "public",
            "private",
            "shared",
            "community"});
            this.cmbImageBoxVisibility.Location = new System.Drawing.Point(47, 385);
            this.cmbImageBoxVisibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbImageBoxVisibility.MaxDropDownItems = 4;
            this.cmbImageBoxVisibility.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbImageBoxVisibility.Name = "cmbImageBoxVisibility";
            this.cmbImageBoxVisibility.Size = new System.Drawing.Size(185, 49);
            this.cmbImageBoxVisibility.StartIndex = 0;
            this.cmbImageBoxVisibility.TabIndex = 15;
            // 
            // lblImageVisibility
            // 
            this.lblImageVisibility.AutoSize = true;
            this.lblImageVisibility.Depth = 0;
            this.lblImageVisibility.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageVisibility.Location = new System.Drawing.Point(44, 363);
            this.lblImageVisibility.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageVisibility.Name = "lblImageVisibility";
            this.lblImageVisibility.Size = new System.Drawing.Size(61, 19);
            this.lblImageVisibility.TabIndex = 14;
            this.lblImageVisibility.Text = "Visibility";
            // 
            // txtImageMinimumRam
            // 
            this.txtImageMinimumRam.AnimateReadOnly = false;
            this.txtImageMinimumRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageMinimumRam.Depth = 0;
            this.txtImageMinimumRam.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageMinimumRam.LeadingIcon = null;
            this.txtImageMinimumRam.Location = new System.Drawing.Point(604, 270);
            this.txtImageMinimumRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageMinimumRam.MaxLength = 50;
            this.txtImageMinimumRam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumRam.Multiline = false;
            this.txtImageMinimumRam.Name = "txtImageMinimumRam";
            this.txtImageMinimumRam.Size = new System.Drawing.Size(155, 50);
            this.txtImageMinimumRam.TabIndex = 13;
            this.txtImageMinimumRam.Text = "";
            this.txtImageMinimumRam.TrailingIcon = null;
            this.txtImageMinimumRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumRam_KeyPress);
            // 
            // txtImageMinimumDisk
            // 
            this.txtImageMinimumDisk.AnimateReadOnly = false;
            this.txtImageMinimumDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageMinimumDisk.Depth = 0;
            this.txtImageMinimumDisk.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageMinimumDisk.LeadingIcon = null;
            this.txtImageMinimumDisk.Location = new System.Drawing.Point(336, 270);
            this.txtImageMinimumDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageMinimumDisk.MaxLength = 50;
            this.txtImageMinimumDisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumDisk.Multiline = false;
            this.txtImageMinimumDisk.Name = "txtImageMinimumDisk";
            this.txtImageMinimumDisk.Size = new System.Drawing.Size(155, 50);
            this.txtImageMinimumDisk.TabIndex = 12;
            this.txtImageMinimumDisk.Text = "";
            this.txtImageMinimumDisk.TrailingIcon = null;
            this.txtImageMinimumDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumDisk_KeyPress);
            // 
            // lblImageMinimumRam
            // 
            this.lblImageMinimumRam.AutoSize = true;
            this.lblImageMinimumRam.Depth = 0;
            this.lblImageMinimumRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageMinimumRam.Location = new System.Drawing.Point(601, 247);
            this.lblImageMinimumRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageMinimumRam.Name = "lblImageMinimumRam";
            this.lblImageMinimumRam.Size = new System.Drawing.Size(146, 19);
            this.lblImageMinimumRam.TabIndex = 11;
            this.lblImageMinimumRam.Text = "Minimum RAM (MB)";
            // 
            // lblImageMinimimDisk
            // 
            this.lblImageMinimimDisk.AutoSize = true;
            this.lblImageMinimimDisk.Depth = 0;
            this.lblImageMinimimDisk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageMinimimDisk.Location = new System.Drawing.Point(333, 247);
            this.lblImageMinimimDisk.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageMinimimDisk.Name = "lblImageMinimimDisk";
            this.lblImageMinimimDisk.Size = new System.Drawing.Size(140, 19);
            this.lblImageMinimimDisk.TabIndex = 10;
            this.lblImageMinimimDisk.Text = "Minimum Disk (GB)";
            // 
            // lblImageDiskFormat
            // 
            this.lblImageDiskFormat.AutoSize = true;
            this.lblImageDiskFormat.Depth = 0;
            this.lblImageDiskFormat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageDiskFormat.Location = new System.Drawing.Point(44, 247);
            this.lblImageDiskFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageDiskFormat.Name = "lblImageDiskFormat";
            this.lblImageDiskFormat.Size = new System.Drawing.Size(87, 19);
            this.lblImageDiskFormat.TabIndex = 9;
            this.lblImageDiskFormat.Text = "Disk Format";
            // 
            // cmbBoxImageDiskFormat
            // 
            this.cmbBoxImageDiskFormat.AutoResize = false;
            this.cmbBoxImageDiskFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxImageDiskFormat.Depth = 0;
            this.cmbBoxImageDiskFormat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxImageDiskFormat.DropDownHeight = 174;
            this.cmbBoxImageDiskFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxImageDiskFormat.DropDownWidth = 121;
            this.cmbBoxImageDiskFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxImageDiskFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxImageDiskFormat.FormattingEnabled = true;
            this.cmbBoxImageDiskFormat.IntegralHeight = false;
            this.cmbBoxImageDiskFormat.ItemHeight = 43;
            this.cmbBoxImageDiskFormat.Items.AddRange(new object[] {
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
            this.cmbBoxImageDiskFormat.Location = new System.Drawing.Point(47, 270);
            this.cmbBoxImageDiskFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxImageDiskFormat.MaxDropDownItems = 4;
            this.cmbBoxImageDiskFormat.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxImageDiskFormat.Name = "cmbBoxImageDiskFormat";
            this.cmbBoxImageDiskFormat.Size = new System.Drawing.Size(185, 49);
            this.cmbBoxImageDiskFormat.StartIndex = 0;
            this.cmbBoxImageDiskFormat.TabIndex = 8;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImageBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImageBrowse.Depth = 0;
            this.btnImageBrowse.HighEmphasis = true;
            this.btnImageBrowse.Icon = null;
            this.btnImageBrowse.Location = new System.Drawing.Point(939, 151);
            this.btnImageBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.txtImageFile.Location = new System.Drawing.Point(47, 151);
            this.txtImageFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageFile.MaxLength = 260;
            this.txtImageFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageFile.Multiline = false;
            this.txtImageFile.Name = "txtImageFile";
            this.txtImageFile.Size = new System.Drawing.Size(873, 50);
            this.txtImageFile.TabIndex = 6;
            this.txtImageFile.Text = "";
            this.txtImageFile.TrailingIcon = null;
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Depth = 0;
            this.lblImageFile.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageFile.Location = new System.Drawing.Point(44, 129);
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
            this.lblImageDescription.Location = new System.Drawing.Point(579, 14);
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
            this.txtImageDescription.Location = new System.Drawing.Point(581, 34);
            this.txtImageDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageDescription.MaxLength = 200;
            this.txtImageDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageDescription.Multiline = false;
            this.txtImageDescription.Name = "txtImageDescription";
            this.txtImageDescription.Size = new System.Drawing.Size(747, 50);
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
            this.txtImageName.Location = new System.Drawing.Point(47, 34);
            this.txtImageName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageName.MaxLength = 50;
            this.txtImageName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageName.Multiline = false;
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(421, 50);
            this.txtImageName.TabIndex = 2;
            this.txtImageName.Text = "";
            this.txtImageName.TrailingIcon = null;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Depth = 0;
            this.lblImageName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageName.Location = new System.Drawing.Point(44, 14);
            this.lblImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(91, 19);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image Name";
            // 
            // imagesTabSelector
            // 
            this.imagesTabSelector.BaseTabControl = this.imagesTabControl;
            this.imagesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.imagesTabSelector.Depth = 0;
            this.imagesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imagesTabSelector.Location = new System.Drawing.Point(3, 2);
            this.imagesTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabSelector.Name = "imagesTabSelector";
            this.imagesTabSelector.Size = new System.Drawing.Size(1536, 48);
            this.imagesTabSelector.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1543, 774);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Volumes";
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
            this.comboBoxProjects.Location = new System.Drawing.Point(1045, 39);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(255, 24);
            this.comboBoxProjects.TabIndex = 1;
            // 
            // logout
            // 
            this.logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logout.Depth = 0;
            this.logout.HighEmphasis = true;
            this.logout.Icon = null;
            this.logout.Location = new System.Drawing.Point(1372, 16);
            this.logout.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.mainTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mainTabControl;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainTabControl.ResumeLayout(false);
            this.ImageServiceTab.ResumeLayout(false);
            this.imagesTabControl.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTabControl imagesTabControl;
        private System.Windows.Forms.TabPage imagesTab;
        private System.Windows.Forms.TabPage createImageTab;
        private MaterialSkin.Controls.MaterialTabSelector imagesTabSelector;
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
        private MaterialSkin.Controls.MaterialLabel lblImageDiskFormat;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxImageDiskFormat;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumRam;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimumRam;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimimDisk;
        private MaterialSkin.Controls.MaterialComboBox cmbImageBoxVisibility;
        private MaterialSkin.Controls.MaterialLabel lblImageVisibility;
        private MaterialSkin.Controls.MaterialSwitch switchImageProtected;
        private MaterialSkin.Controls.MaterialButton logout;
    }
}