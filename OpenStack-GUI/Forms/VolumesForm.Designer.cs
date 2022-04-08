
namespace OpenStack_GUI.Forms
{
    partial class VolumesForm
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
            this.volumesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.volumesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.volumesGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.availabilityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.typeLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.sourceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.lblVolumeName = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.availabilityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.sizeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.sourceComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.VolumeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAvailabilityZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBootable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEncrypted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CreateVolumeButton = new MaterialSkin.Controls.MaterialButton();
            this.volumesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumesGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // volumesTabSelector
            // 
            this.volumesTabSelector.BaseTabControl = this.volumesTabControl;
            this.volumesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.volumesTabSelector.Depth = 0;
            this.volumesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.volumesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.volumesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.volumesTabSelector.Margin = new System.Windows.Forms.Padding(2);
            this.volumesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabSelector.Name = "volumesTabSelector";
            this.volumesTabSelector.Size = new System.Drawing.Size(1139, 39);
            this.volumesTabSelector.TabIndex = 0;
            this.volumesTabSelector.Text = "materialTabSelector1";
            // 
            // volumesTabControl
            // 
            this.volumesTabControl.Controls.Add(this.tabPage1);
            this.volumesTabControl.Controls.Add(this.tabPage2);
            this.volumesTabControl.Depth = 0;
            this.volumesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumesTabControl.Location = new System.Drawing.Point(0, 39);
            this.volumesTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.volumesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabControl.Multiline = true;
            this.volumesTabControl.Name = "volumesTabControl";
            this.volumesTabControl.SelectedIndex = 0;
            this.volumesTabControl.Size = new System.Drawing.Size(1139, 543);
            this.volumesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.volumesGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1131, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Volumes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // volumesGridView
            // 
            this.volumesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.volumesGridView.BackgroundColor = System.Drawing.Color.White;
            this.volumesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volumesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.volumesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.columnName,
            this.columnDescription,
            this.columnSize,
            this.columnStatus,
            this.columnGroup,
            this.columnType,
            this.columnAvailabilityZone,
            this.columnBootable,
            this.columnEncrypted,
            this.deleteColumn});
            this.volumesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumesGridView.GridColor = System.Drawing.Color.White;
            this.volumesGridView.Location = new System.Drawing.Point(2, 2);
            this.volumesGridView.Name = "volumesGridView";
            this.volumesGridView.RowHeadersWidth = 51;
            this.volumesGridView.Size = new System.Drawing.Size(1127, 513);
            this.volumesGridView.TabIndex = 0;
            this.volumesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.CreateVolumeButton);
            this.tabPage2.Controls.Add(this.availabilityLabel);
            this.tabPage2.Controls.Add(this.SizeLabel);
            this.tabPage2.Controls.Add(this.typeLabel1);
            this.tabPage2.Controls.Add(this.sourceLabel);
            this.tabPage2.Controls.Add(this.DescriptionLabel);
            this.tabPage2.Controls.Add(this.lblVolumeName);
            this.tabPage2.Controls.Add(this.DescriptionTextBox);
            this.tabPage2.Controls.Add(this.availabilityComboBox);
            this.tabPage2.Controls.Add(this.sizeTextBox);
            this.tabPage2.Controls.Add(this.TypeComboBox);
            this.tabPage2.Controls.Add(this.sourceComboBox);
            this.tabPage2.Controls.Add(this.VolumeTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1131, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Volumes";
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.Depth = 0;
            this.availabilityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availabilityLabel.Location = new System.Drawing.Point(461, 266);
            this.availabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availabilityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(119, 19);
            this.availabilityLabel.TabIndex = 19;
            this.availabilityLabel.Text = "Availability Zone";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Depth = 0;
            this.SizeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SizeLabel.Location = new System.Drawing.Point(28, 266);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(31, 19);
            this.SizeLabel.TabIndex = 18;
            this.SizeLabel.Text = "Size";
            // 
            // typeLabel1
            // 
            this.typeLabel1.AutoSize = true;
            this.typeLabel1.Depth = 0;
            this.typeLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.typeLabel1.Location = new System.Drawing.Point(456, 136);
            this.typeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.typeLabel1.Name = "typeLabel1";
            this.typeLabel1.Size = new System.Drawing.Size(36, 19);
            this.typeLabel1.TabIndex = 17;
            this.typeLabel1.Text = "Type";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Depth = 0;
            this.sourceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceLabel.Location = new System.Drawing.Point(28, 136);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sourceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(108, 19);
            this.sourceLabel.TabIndex = 16;
            this.sourceLabel.Text = "Volume Source";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Depth = 0;
            this.DescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionLabel.Location = new System.Drawing.Point(456, 20);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(81, 19);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description";
            // 
            // lblVolumeName
            // 
            this.lblVolumeName.AutoSize = true;
            this.lblVolumeName.Depth = 0;
            this.lblVolumeName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVolumeName.Location = new System.Drawing.Point(28, 20);
            this.lblVolumeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVolumeName.Name = "lblVolumeName";
            this.lblVolumeName.Size = new System.Drawing.Size(101, 19);
            this.lblVolumeName.TabIndex = 14;
            this.lblVolumeName.Text = "Volume Name";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AnimateReadOnly = false;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Depth = 0;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescriptionTextBox.LeadingIcon = null;
            this.DescriptionTextBox.Location = new System.Drawing.Point(459, 42);
            this.DescriptionTextBox.MaxLength = 50;
            this.DescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DescriptionTextBox.Multiline = false;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(332, 50);
            this.DescriptionTextBox.TabIndex = 13;
            this.DescriptionTextBox.Text = "";
            this.DescriptionTextBox.TrailingIcon = null;
            // 
            // availabilityComboBox
            // 
            this.availabilityComboBox.AutoResize = false;
            this.availabilityComboBox.BackColor = System.Drawing.Color.White;
            this.availabilityComboBox.Depth = 0;
            this.availabilityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.availabilityComboBox.DropDownHeight = 174;
            this.availabilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availabilityComboBox.DropDownWidth = 121;
            this.availabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.availabilityComboBox.ForeColor = System.Drawing.Color.Black;
            this.availabilityComboBox.FormattingEnabled = true;
            this.availabilityComboBox.IntegralHeight = false;
            this.availabilityComboBox.ItemHeight = 43;
            this.availabilityComboBox.Items.AddRange(new object[] {
            "nova"});
            this.availabilityComboBox.Location = new System.Drawing.Point(459, 289);
            this.availabilityComboBox.MaxDropDownItems = 4;
            this.availabilityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.availabilityComboBox.Name = "availabilityComboBox";
            this.availabilityComboBox.Size = new System.Drawing.Size(332, 49);
            this.availabilityComboBox.StartIndex = 0;
            this.availabilityComboBox.TabIndex = 12;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.AnimateReadOnly = false;
            this.sizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sizeTextBox.Depth = 0;
            this.sizeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sizeTextBox.LeadingIcon = null;
            this.sizeTextBox.Location = new System.Drawing.Point(31, 288);
            this.sizeTextBox.MaxLength = 50;
            this.sizeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sizeTextBox.Multiline = false;
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(329, 50);
            this.sizeTextBox.TabIndex = 10;
            this.sizeTextBox.Text = "";
            this.sizeTextBox.TrailingIcon = null;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.AutoResize = false;
            this.TypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeComboBox.Depth = 0;
            this.TypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TypeComboBox.DropDownHeight = 174;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.DropDownWidth = 121;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.IntegralHeight = false;
            this.TypeComboBox.ItemHeight = 43;
            this.TypeComboBox.Items.AddRange(new object[] {
            "_DEFAULT_"});
            this.TypeComboBox.Location = new System.Drawing.Point(459, 167);
            this.TypeComboBox.MaxDropDownItems = 4;
            this.TypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(332, 49);
            this.TypeComboBox.StartIndex = 0;
            this.TypeComboBox.TabIndex = 8;
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.AutoResize = false;
            this.sourceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sourceComboBox.Depth = 0;
            this.sourceComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sourceComboBox.DropDownHeight = 174;
            this.sourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceComboBox.DropDownWidth = 121;
            this.sourceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sourceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.IntegralHeight = false;
            this.sourceComboBox.ItemHeight = 43;
            this.sourceComboBox.Items.AddRange(new object[] {
            "No source, empty volume",
            "Image",
            "Volume"});
            this.sourceComboBox.Location = new System.Drawing.Point(31, 167);
            this.sourceComboBox.MaxDropDownItems = 4;
            this.sourceComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(329, 49);
            this.sourceComboBox.StartIndex = 0;
            this.sourceComboBox.TabIndex = 6;
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.AnimateReadOnly = false;
            this.VolumeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VolumeTextBox.Depth = 0;
            this.VolumeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.VolumeTextBox.LeadingIcon = null;
            this.VolumeTextBox.Location = new System.Drawing.Point(31, 42);
            this.VolumeTextBox.MaxLength = 50;
            this.VolumeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.VolumeTextBox.Multiline = false;
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(332, 50);
            this.VolumeTextBox.TabIndex = 0;
            this.VolumeTextBox.Text = "";
            this.VolumeTextBox.TrailingIcon = null;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.Name = "columnDescription";
            // 
            // columnSize
            // 
            this.columnSize.HeaderText = "Size";
            this.columnSize.Name = "columnSize";
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.Name = "columnStatus";
            // 
            // columnGroup
            // 
            this.columnGroup.HeaderText = "Group";
            this.columnGroup.Name = "columnGroup";
            // 
            // columnType
            // 
            this.columnType.HeaderText = "Type";
            this.columnType.Name = "columnType";
            // 
            // columnAvailabilityZone
            // 
            this.columnAvailabilityZone.HeaderText = "Availability Zone";
            this.columnAvailabilityZone.Name = "columnAvailabilityZone";
            // 
            // columnBootable
            // 
            this.columnBootable.HeaderText = "Bootable";
            this.columnBootable.Name = "columnBootable";
            // 
            // columnEncrypted
            // 
            this.columnEncrypted.HeaderText = "Encrypted";
            this.columnEncrypted.Name = "columnEncrypted";
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreateVolumeButton
            // 
            this.CreateVolumeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateVolumeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateVolumeButton.Depth = 0;
            this.CreateVolumeButton.HighEmphasis = true;
            this.CreateVolumeButton.Icon = null;
            this.CreateVolumeButton.Location = new System.Drawing.Point(31, 388);
            this.CreateVolumeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateVolumeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateVolumeButton.Name = "CreateVolumeButton";
            this.CreateVolumeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateVolumeButton.Size = new System.Drawing.Size(138, 36);
            this.CreateVolumeButton.TabIndex = 20;
            this.CreateVolumeButton.Text = "Create Volume";
            this.CreateVolumeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateVolumeButton.UseAccentColor = false;
            this.CreateVolumeButton.UseVisualStyleBackColor = true;
            this.CreateVolumeButton.Click += new System.EventHandler(this.CreateVolumeButton_Click);
            // 
            // VolumesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 582);
            this.ControlBox = false;
            this.Controls.Add(this.volumesTabControl);
            this.Controls.Add(this.volumesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Volumes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Volumes_Load);
            this.volumesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.volumesGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector volumesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl volumesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView volumesGridView;
        private MaterialSkin.Controls.MaterialTextBox VolumeTextBox;
        private MaterialSkin.Controls.MaterialComboBox sourceComboBox;
        private MaterialSkin.Controls.MaterialComboBox TypeComboBox;
        private MaterialSkin.Controls.MaterialComboBox availabilityComboBox;
        private MaterialSkin.Controls.MaterialTextBox sizeTextBox;
        private MaterialSkin.Controls.MaterialTextBox DescriptionTextBox;
        private MaterialSkin.Controls.MaterialLabel DescriptionLabel;
        private MaterialSkin.Controls.MaterialLabel lblVolumeName;
        private MaterialSkin.Controls.MaterialLabel sourceLabel;
        private MaterialSkin.Controls.MaterialLabel typeLabel1;
        private MaterialSkin.Controls.MaterialLabel SizeLabel;
        private MaterialSkin.Controls.MaterialLabel availabilityLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAvailabilityZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBootable;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEncrypted;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private MaterialSkin.Controls.MaterialButton CreateVolumeButton;
    }
}