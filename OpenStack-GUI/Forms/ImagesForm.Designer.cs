
namespace OpenStack_GUI.Forms
{
    partial class ImagesForm
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
            this.imagesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.imagesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.imagesTab = new System.Windows.Forms.TabPage();
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.collumnLineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.collumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnVisibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnProtected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnDiskFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnContainerFormt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDeleteImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.collumnEditImage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createImageTab = new System.Windows.Forms.TabPage();
            this.txtImageDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCreateImage = new MaterialSkin.Controls.MaterialButton();
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
            this.txtImageName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblImageName = new MaterialSkin.Controls.MaterialLabel();
            this.editImageTab = new System.Windows.Forms.TabPage();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox7 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox8 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox4 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox9 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox10 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.imagesTabControl.SuspendLayout();
            this.imagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            this.createImageTab.SuspendLayout();
            this.editImageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagesTabSelector
            // 
            this.imagesTabSelector.BaseTabControl = this.imagesTabControl;
            this.imagesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.imagesTabSelector.Depth = 0;
            this.imagesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imagesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.imagesTabSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabSelector.Name = "imagesTabSelector";
            this.imagesTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.imagesTabSelector.TabIndex = 1;
            // 
            // imagesTabControl
            // 
            this.imagesTabControl.Controls.Add(this.imagesTab);
            this.imagesTabControl.Controls.Add(this.createImageTab);
            this.imagesTabControl.Controls.Add(this.editImageTab);
            this.imagesTabControl.Depth = 0;
            this.imagesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesTabControl.Location = new System.Drawing.Point(0, 48);
            this.imagesTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.imagesTabControl.Multiline = true;
            this.imagesTabControl.Name = "imagesTabControl";
            this.imagesTabControl.SelectedIndex = 0;
            this.imagesTabControl.Size = new System.Drawing.Size(1519, 668);
            this.imagesTabControl.TabIndex = 2;
            // 
            // imagesTab
            // 
            this.imagesTab.BackColor = System.Drawing.Color.White;
            this.imagesTab.Controls.Add(this.imagesDataGridView);
            this.imagesTab.Location = new System.Drawing.Point(4, 25);
            this.imagesTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesTab.Size = new System.Drawing.Size(1511, 639);
            this.imagesTab.TabIndex = 0;
            this.imagesTab.Text = "Images";
            // 
            // imagesDataGridView
            // 
            this.imagesDataGridView.AllowUserToAddRows = false;
            this.imagesDataGridView.AllowUserToDeleteRows = false;
            this.imagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imagesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.imagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collumnLineNumber,
            this.check,
            this.collumnID,
            this.collumnProjectId,
            this.collumnName,
            this.collumnStatus,
            this.collumnVisibility,
            this.collumnProtected,
            this.collumnDiskFormat,
            this.collumnContainerFormt,
            this.collumnSize,
            this.columnDeleteImage,
            this.collumnEditImage});
            this.imagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesDataGridView.GridColor = System.Drawing.Color.White;
            this.imagesDataGridView.Location = new System.Drawing.Point(3, 2);
            this.imagesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.ReadOnly = true;
            this.imagesDataGridView.RowHeadersWidth = 51;
            this.imagesDataGridView.RowTemplate.Height = 24;
            this.imagesDataGridView.Size = new System.Drawing.Size(1505, 635);
            this.imagesDataGridView.TabIndex = 1;
            this.imagesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imagesDataGridView_CellClick);
            // 
            // collumnLineNumber
            // 
            this.collumnLineNumber.HeaderText = "";
            this.collumnLineNumber.MinimumWidth = 6;
            this.collumnLineNumber.Name = "collumnLineNumber";
            this.collumnLineNumber.ReadOnly = true;
            this.collumnLineNumber.Visible = false;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.check.FillWeight = 28.877F;
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 20;
            // 
            // collumnID
            // 
            this.collumnID.HeaderText = "ID";
            this.collumnID.MinimumWidth = 6;
            this.collumnID.Name = "collumnID";
            this.collumnID.ReadOnly = true;
            this.collumnID.Visible = false;
            // 
            // collumnProjectId
            // 
            this.collumnProjectId.HeaderText = "Project ID";
            this.collumnProjectId.MinimumWidth = 6;
            this.collumnProjectId.Name = "collumnProjectId";
            this.collumnProjectId.ReadOnly = true;
            this.collumnProjectId.Visible = false;
            // 
            // collumnName
            // 
            this.collumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnName.FillWeight = 668.984F;
            this.collumnName.HeaderText = "Name";
            this.collumnName.MinimumWidth = 6;
            this.collumnName.Name = "collumnName";
            this.collumnName.ReadOnly = true;
            this.collumnName.Width = 200;
            // 
            // collumnStatus
            // 
            this.collumnStatus.FillWeight = 28.877F;
            this.collumnStatus.HeaderText = "Status";
            this.collumnStatus.MinimumWidth = 6;
            this.collumnStatus.Name = "collumnStatus";
            this.collumnStatus.ReadOnly = true;
            // 
            // collumnVisibility
            // 
            this.collumnVisibility.FillWeight = 28.877F;
            this.collumnVisibility.HeaderText = "Visibility";
            this.collumnVisibility.MinimumWidth = 6;
            this.collumnVisibility.Name = "collumnVisibility";
            this.collumnVisibility.ReadOnly = true;
            // 
            // collumnProtected
            // 
            this.collumnProtected.FillWeight = 28.877F;
            this.collumnProtected.HeaderText = "Protected";
            this.collumnProtected.MinimumWidth = 6;
            this.collumnProtected.Name = "collumnProtected";
            this.collumnProtected.ReadOnly = true;
            // 
            // collumnDiskFormat
            // 
            this.collumnDiskFormat.FillWeight = 28.877F;
            this.collumnDiskFormat.HeaderText = "Disk Format";
            this.collumnDiskFormat.MinimumWidth = 6;
            this.collumnDiskFormat.Name = "collumnDiskFormat";
            this.collumnDiskFormat.ReadOnly = true;
            // 
            // collumnContainerFormt
            // 
            this.collumnContainerFormt.FillWeight = 28.877F;
            this.collumnContainerFormt.HeaderText = "Container Format";
            this.collumnContainerFormt.MinimumWidth = 6;
            this.collumnContainerFormt.Name = "collumnContainerFormt";
            this.collumnContainerFormt.ReadOnly = true;
            // 
            // collumnSize
            // 
            this.collumnSize.FillWeight = 28.877F;
            this.collumnSize.HeaderText = "Size";
            this.collumnSize.MinimumWidth = 6;
            this.collumnSize.Name = "collumnSize";
            this.collumnSize.ReadOnly = true;
            // 
            // columnDeleteImage
            // 
            this.columnDeleteImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnDeleteImage.FillWeight = 28.877F;
            this.columnDeleteImage.HeaderText = "Delete";
            this.columnDeleteImage.MinimumWidth = 6;
            this.columnDeleteImage.Name = "columnDeleteImage";
            this.columnDeleteImage.ReadOnly = true;
            this.columnDeleteImage.Text = "Delete";
            this.columnDeleteImage.Width = 50;
            // 
            // collumnEditImage
            // 
            this.collumnEditImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.collumnEditImage.HeaderText = "Edit";
            this.collumnEditImage.MinimumWidth = 6;
            this.collumnEditImage.Name = "collumnEditImage";
            this.collumnEditImage.ReadOnly = true;
            this.collumnEditImage.Width = 50;
            // 
            // createImageTab
            // 
            this.createImageTab.BackColor = System.Drawing.Color.White;
            this.createImageTab.Controls.Add(this.txtImageDescription);
            this.createImageTab.Controls.Add(this.btnCreateImage);
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
            this.createImageTab.Controls.Add(this.txtImageName);
            this.createImageTab.Controls.Add(this.lblImageName);
            this.createImageTab.Location = new System.Drawing.Point(4, 25);
            this.createImageTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createImageTab.Name = "createImageTab";
            this.createImageTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createImageTab.Size = new System.Drawing.Size(1511, 639);
            this.createImageTab.TabIndex = 1;
            this.createImageTab.Text = "Create Image";
            // 
            // txtImageDescription
            // 
            this.txtImageDescription.AnimateReadOnly = false;
            this.txtImageDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageDescription.Depth = 0;
            this.txtImageDescription.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageDescription.LeadingIcon = null;
            this.txtImageDescription.Location = new System.Drawing.Point(525, 151);
            this.txtImageDescription.MaxLength = 255;
            this.txtImageDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageDescription.Multiline = false;
            this.txtImageDescription.Name = "txtImageDescription";
            this.txtImageDescription.Size = new System.Drawing.Size(500, 50);
            this.txtImageDescription.TabIndex = 18;
            this.txtImageDescription.Text = "";
            this.txtImageDescription.TrailingIcon = null;
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateImage.Depth = 0;
            this.btnCreateImage.HighEmphasis = true;
            this.btnCreateImage.Icon = null;
            this.btnCreateImage.Location = new System.Drawing.Point(47, 488);
            this.btnCreateImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateImage.Size = new System.Drawing.Size(125, 36);
            this.btnCreateImage.TabIndex = 17;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateImage.UseAccentColor = false;
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // switchImageProtected
            // 
            this.switchImageProtected.AutoSize = true;
            this.switchImageProtected.Depth = 0;
            this.switchImageProtected.Location = new System.Drawing.Point(336, 487);
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
            "shared",
            "public",
            "private",
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
            this.txtImageMinimumRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtImageMinimumRam.LeadingIcon = null;
            this.txtImageMinimumRam.Location = new System.Drawing.Point(336, 384);
            this.txtImageMinimumRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageMinimumRam.MaxLength = 50;
            this.txtImageMinimumRam.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumRam.Multiline = false;
            this.txtImageMinimumRam.Name = "txtImageMinimumRam";
            this.txtImageMinimumRam.Size = new System.Drawing.Size(155, 50);
            this.txtImageMinimumRam.TabIndex = 13;
            this.txtImageMinimumRam.Text = "0";
            this.txtImageMinimumRam.TrailingIcon = null;
            this.txtImageMinimumRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumRam_KeyPress);
            // 
            // txtImageMinimumDisk
            // 
            this.txtImageMinimumDisk.AnimateReadOnly = false;
            this.txtImageMinimumDisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageMinimumDisk.Depth = 0;
            this.txtImageMinimumDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtImageMinimumDisk.LeadingIcon = null;
            this.txtImageMinimumDisk.Location = new System.Drawing.Point(336, 270);
            this.txtImageMinimumDisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImageMinimumDisk.MaxLength = 50;
            this.txtImageMinimumDisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtImageMinimumDisk.Multiline = false;
            this.txtImageMinimumDisk.Name = "txtImageMinimumDisk";
            this.txtImageMinimumDisk.Size = new System.Drawing.Size(155, 50);
            this.txtImageMinimumDisk.TabIndex = 12;
            this.txtImageMinimumDisk.Text = "0";
            this.txtImageMinimumDisk.TrailingIcon = null;
            this.txtImageMinimumDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimumDisk_KeyPress);
            // 
            // lblImageMinimumRam
            // 
            this.lblImageMinimumRam.AutoSize = true;
            this.lblImageMinimumRam.Depth = 0;
            this.lblImageMinimumRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblImageMinimumRam.Location = new System.Drawing.Point(333, 363);
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
            "QCOW2",
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
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
            this.btnImageBrowse.Location = new System.Drawing.Point(945, 39);
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
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // txtImageFile
            // 
            this.txtImageFile.AnimateReadOnly = false;
            this.txtImageFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageFile.Depth = 0;
            this.txtImageFile.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageFile.LeadingIcon = null;
            this.txtImageFile.Location = new System.Drawing.Point(47, 34);
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
            this.lblImageFile.Location = new System.Drawing.Point(44, 14);
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
            this.lblImageDescription.Location = new System.Drawing.Point(522, 129);
            this.lblImageDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageDescription.Name = "lblImageDescription";
            this.lblImageDescription.Size = new System.Drawing.Size(129, 19);
            this.lblImageDescription.TabIndex = 4;
            this.lblImageDescription.Text = "Image Description";
            // 
            // txtImageName
            // 
            this.txtImageName.AnimateReadOnly = false;
            this.txtImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageName.Depth = 0;
            this.txtImageName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtImageName.LeadingIcon = null;
            this.txtImageName.Location = new System.Drawing.Point(47, 150);
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
            this.lblImageName.Location = new System.Drawing.Point(44, 129);
            this.lblImageName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(91, 19);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image Name";
            // 
            // editImageTab
            // 
            this.editImageTab.BackColor = System.Drawing.Color.White;
            this.editImageTab.Controls.Add(this.materialTextBox6);
            this.editImageTab.Controls.Add(this.materialButton3);
            this.editImageTab.Controls.Add(this.materialSwitch2);
            this.editImageTab.Controls.Add(this.materialComboBox3);
            this.editImageTab.Controls.Add(this.materialLabel8);
            this.editImageTab.Controls.Add(this.materialTextBox7);
            this.editImageTab.Controls.Add(this.materialTextBox8);
            this.editImageTab.Controls.Add(this.materialLabel9);
            this.editImageTab.Controls.Add(this.materialLabel10);
            this.editImageTab.Controls.Add(this.materialLabel11);
            this.editImageTab.Controls.Add(this.materialComboBox4);
            this.editImageTab.Controls.Add(this.materialButton4);
            this.editImageTab.Controls.Add(this.materialTextBox9);
            this.editImageTab.Controls.Add(this.materialLabel12);
            this.editImageTab.Controls.Add(this.materialLabel13);
            this.editImageTab.Controls.Add(this.materialTextBox10);
            this.editImageTab.Controls.Add(this.materialLabel14);
            this.editImageTab.Location = new System.Drawing.Point(4, 25);
            this.editImageTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editImageTab.Name = "editImageTab";
            this.editImageTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editImageTab.Size = new System.Drawing.Size(1511, 639);
            this.editImageTab.TabIndex = 3;
            this.editImageTab.Text = "Edit Image";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.AnimateReadOnly = false;
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox6.LeadingIcon = null;
            this.materialTextBox6.Location = new System.Drawing.Point(525, 151);
            this.materialTextBox6.MaxLength = 255;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(500, 50);
            this.materialTextBox6.TabIndex = 18;
            this.materialTextBox6.Text = "";
            this.materialTextBox6.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(47, 488);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(125, 36);
            this.materialButton3.TabIndex = 17;
            this.materialButton3.Text = "Create Image";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.AutoSize = true;
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Location = new System.Drawing.Point(336, 487);
            this.materialSwitch2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch2.Name = "materialSwitch2";
            this.materialSwitch2.Ripple = true;
            this.materialSwitch2.Size = new System.Drawing.Size(125, 37);
            this.materialSwitch2.TabIndex = 16;
            this.materialSwitch2.Text = "Protected";
            this.materialSwitch2.UseVisualStyleBackColor = true;
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Items.AddRange(new object[] {
            "shared",
            "public",
            "private",
            "community"});
            this.materialComboBox3.Location = new System.Drawing.Point(47, 385);
            this.materialComboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(185, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 15;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(44, 363);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(61, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Visibility";
            // 
            // materialTextBox7
            // 
            this.materialTextBox7.AnimateReadOnly = false;
            this.materialTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox7.Depth = 0;
            this.materialTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox7.LeadingIcon = null;
            this.materialTextBox7.Location = new System.Drawing.Point(336, 384);
            this.materialTextBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox7.MaxLength = 50;
            this.materialTextBox7.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox7.Multiline = false;
            this.materialTextBox7.Name = "materialTextBox7";
            this.materialTextBox7.Size = new System.Drawing.Size(155, 50);
            this.materialTextBox7.TabIndex = 13;
            this.materialTextBox7.Text = "0";
            this.materialTextBox7.TrailingIcon = null;
            // 
            // materialTextBox8
            // 
            this.materialTextBox8.AnimateReadOnly = false;
            this.materialTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox8.Depth = 0;
            this.materialTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.materialTextBox8.LeadingIcon = null;
            this.materialTextBox8.Location = new System.Drawing.Point(336, 270);
            this.materialTextBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox8.MaxLength = 50;
            this.materialTextBox8.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox8.Multiline = false;
            this.materialTextBox8.Name = "materialTextBox8";
            this.materialTextBox8.Size = new System.Drawing.Size(155, 50);
            this.materialTextBox8.TabIndex = 12;
            this.materialTextBox8.Text = "0";
            this.materialTextBox8.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(333, 363);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(146, 19);
            this.materialLabel9.TabIndex = 11;
            this.materialLabel9.Text = "Minimum RAM (MB)";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(333, 247);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(140, 19);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Minimum Disk (GB)";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(44, 247);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(87, 19);
            this.materialLabel11.TabIndex = 9;
            this.materialLabel11.Text = "Disk Format";
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.AutoResize = false;
            this.materialComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox4.Depth = 0;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownHeight = 174;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.IntegralHeight = false;
            this.materialComboBox4.ItemHeight = 43;
            this.materialComboBox4.Items.AddRange(new object[] {
            "QCOW2",
            "AMI",
            "ARI",
            "AKI",
            "VHD",
            "VHDX",
            "VMDK",
            "RAW",
            "VDI",
            "PLOOP",
            "ISO"});
            this.materialComboBox4.Location = new System.Drawing.Point(47, 270);
            this.materialComboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.Size = new System.Drawing.Size(185, 49);
            this.materialComboBox4.StartIndex = 0;
            this.materialComboBox4.TabIndex = 8;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(945, 39);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(80, 36);
            this.materialButton4.TabIndex = 7;
            this.materialButton4.Text = "Browse";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialTextBox9
            // 
            this.materialTextBox9.AnimateReadOnly = false;
            this.materialTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox9.Depth = 0;
            this.materialTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox9.LeadingIcon = null;
            this.materialTextBox9.Location = new System.Drawing.Point(47, 34);
            this.materialTextBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox9.MaxLength = 260;
            this.materialTextBox9.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox9.Multiline = false;
            this.materialTextBox9.Name = "materialTextBox9";
            this.materialTextBox9.Size = new System.Drawing.Size(873, 50);
            this.materialTextBox9.TabIndex = 6;
            this.materialTextBox9.Text = "";
            this.materialTextBox9.TrailingIcon = null;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(44, 14);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(138, 19);
            this.materialLabel12.TabIndex = 5;
            this.materialLabel12.Text = "Image Source (File)";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(522, 129);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(129, 19);
            this.materialLabel13.TabIndex = 4;
            this.materialLabel13.Text = "Image Description";
            // 
            // materialTextBox10
            // 
            this.materialTextBox10.AnimateReadOnly = false;
            this.materialTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox10.Depth = 0;
            this.materialTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox10.LeadingIcon = null;
            this.materialTextBox10.Location = new System.Drawing.Point(47, 150);
            this.materialTextBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox10.MaxLength = 50;
            this.materialTextBox10.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox10.Multiline = false;
            this.materialTextBox10.Name = "materialTextBox10";
            this.materialTextBox10.Size = new System.Drawing.Size(421, 50);
            this.materialTextBox10.TabIndex = 2;
            this.materialTextBox10.Text = "";
            this.materialTextBox10.TrailingIcon = null;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(44, 129);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(91, 19);
            this.materialLabel14.TabIndex = 0;
            this.materialLabel14.Text = "Image Name";
            // 
            // ImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.imagesTabControl);
            this.Controls.Add(this.imagesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ImagesForm";
            this.imagesTabControl.ResumeLayout(false);
            this.imagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            this.createImageTab.ResumeLayout(false);
            this.createImageTab.PerformLayout();
            this.editImageTab.ResumeLayout(false);
            this.editImageTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector imagesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl imagesTabControl;
        private System.Windows.Forms.TabPage imagesTab;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.TabPage createImageTab;
        private MaterialSkin.Controls.MaterialSwitch switchImageProtected;
        private MaterialSkin.Controls.MaterialComboBox cmbImageBoxVisibility;
        private MaterialSkin.Controls.MaterialLabel lblImageVisibility;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumRam;
        private MaterialSkin.Controls.MaterialTextBox txtImageMinimumDisk;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimumRam;
        private MaterialSkin.Controls.MaterialLabel lblImageMinimimDisk;
        private MaterialSkin.Controls.MaterialLabel lblImageDiskFormat;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxImageDiskFormat;
        private MaterialSkin.Controls.MaterialButton btnImageBrowse;
        private MaterialSkin.Controls.MaterialTextBox txtImageFile;
        private MaterialSkin.Controls.MaterialLabel lblImageFile;
        private MaterialSkin.Controls.MaterialLabel lblImageDescription;
        private MaterialSkin.Controls.MaterialTextBox txtImageName;
        private MaterialSkin.Controls.MaterialLabel lblImageName;
        private MaterialSkin.Controls.MaterialButton btnCreateImage;
        private MaterialSkin.Controls.MaterialTextBox txtImageDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnLineNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnProtected;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnDiskFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnContainerFormt;
        private System.Windows.Forms.DataGridViewTextBoxColumn collumnSize;
        private System.Windows.Forms.DataGridViewButtonColumn columnDeleteImage;
        private System.Windows.Forms.DataGridViewButtonColumn collumnEditImage;
        private System.Windows.Forms.TabPage editImageTab;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox7;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox4;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox9;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox10;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
    }
}