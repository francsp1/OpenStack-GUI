﻿
namespace OpenStack_GUI.Forms
{
    partial class InstancesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstancesForm));
            this.instancesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.instancesTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.instancesTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // instancesTabSelector
            // 
            this.instancesTabSelector.BaseTabControl = this.instancesTabControl;
            this.instancesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.instancesTabSelector.Depth = 0;
            this.instancesTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.instancesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.instancesTabSelector.Location = new System.Drawing.Point(0, 0);
            this.instancesTabSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instancesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabSelector.Name = "instancesTabSelector";
            this.instancesTabSelector.Size = new System.Drawing.Size(1519, 59);
            this.instancesTabSelector.TabIndex = 0;
            this.instancesTabSelector.Text = "materialTabSelector1";
            // 
            // instancesTabControl
            // 
            this.instancesTabControl.Controls.Add(this.tabPage1);
            this.instancesTabControl.Controls.Add(this.tabPage2);
            this.instancesTabControl.Depth = 0;
            this.instancesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instancesTabControl.Location = new System.Drawing.Point(0, 59);
            this.instancesTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instancesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.instancesTabControl.Multiline = true;
            this.instancesTabControl.Name = "instancesTabControl";
            this.instancesTabControl.SelectedIndex = 0;
            this.instancesTabControl.Size = new System.Drawing.Size(1519, 657);
            this.instancesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1511, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.imgNameColumn,
            this.ipColumn,
            this.flavorColumn,
            this.keyColumn,
            this.statusColumn,
            this.zoneColumn,
            this.taskColumn,
            this.powerColumn,
            this.ageColumn,
            this.editColumn,
            this.deleteColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1503, 620);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Instance Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // imgNameColumn
            // 
            this.imgNameColumn.HeaderText = "Image Name";
            this.imgNameColumn.MinimumWidth = 6;
            this.imgNameColumn.Name = "imgNameColumn";
            this.imgNameColumn.ReadOnly = true;
            // 
            // ipColumn
            // 
            this.ipColumn.HeaderText = "IP Address";
            this.ipColumn.MinimumWidth = 6;
            this.ipColumn.Name = "ipColumn";
            this.ipColumn.ReadOnly = true;
            // 
            // flavorColumn
            // 
            this.flavorColumn.HeaderText = "Flavor";
            this.flavorColumn.MinimumWidth = 6;
            this.flavorColumn.Name = "flavorColumn";
            this.flavorColumn.ReadOnly = true;
            // 
            // keyColumn
            // 
            this.keyColumn.HeaderText = "Key Pair";
            this.keyColumn.MinimumWidth = 6;
            this.keyColumn.Name = "keyColumn";
            this.keyColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // zoneColumn
            // 
            this.zoneColumn.HeaderText = "Availability Zone";
            this.zoneColumn.MinimumWidth = 6;
            this.zoneColumn.Name = "zoneColumn";
            this.zoneColumn.ReadOnly = true;
            // 
            // taskColumn
            // 
            this.taskColumn.HeaderText = "Task";
            this.taskColumn.MinimumWidth = 6;
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            // 
            // powerColumn
            // 
            this.powerColumn.HeaderText = "Power State";
            this.powerColumn.MinimumWidth = 6;
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.ReadOnly = true;
            // 
            // ageColumn
            // 
            this.ageColumn.HeaderText = "Age";
            this.ageColumn.MinimumWidth = 6;
            this.ageColumn.Name = "ageColumn";
            this.ageColumn.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.editColumn.HeaderText = "Edit";
            this.editColumn.Image = ((System.Drawing.Image)(resources.GetObject("editColumn.Image")));
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 38;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumn.Image")));
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 78;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1511, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cretate Instances";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InstancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.instancesTabControl);
            this.Controls.Add(this.instancesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstancesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Instances";
            this.TransparencyKey = System.Drawing.Color.White;
            this.instancesTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector instancesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl instancesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageColumn;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}