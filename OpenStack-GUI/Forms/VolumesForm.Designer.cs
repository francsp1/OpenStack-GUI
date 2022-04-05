
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
            this.volumesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumesGridView)).BeginInit();
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
            this.columnEncrypted});
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1131, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Volumes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 6;
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
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector volumesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl volumesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView volumesGridView;
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
    }
}