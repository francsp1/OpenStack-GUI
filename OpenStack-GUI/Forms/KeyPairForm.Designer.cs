
namespace OpenStack_GUI.Forms
{
    partial class KeyPairForm
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
            this.keysTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageKeyPair = new System.Windows.Forms.TabPage();
            this.tabPageCreateKey = new System.Windows.Forms.TabPage();
            this.keysGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerprintColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPageKeyPair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // keysTabSelector1
            // 
            this.keysTabSelector1.BaseTabControl = this.materialTabControl1;
            this.keysTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.keysTabSelector1.Depth = 0;
            this.keysTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.keysTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.keysTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.keysTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.keysTabSelector1.Name = "keysTabSelector1";
            this.keysTabSelector1.Size = new System.Drawing.Size(1139, 48);
            this.keysTabSelector1.TabIndex = 0;
            this.keysTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageKeyPair);
            this.materialTabControl1.Controls.Add(this.tabPageCreateKey);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 48);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1139, 495);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPageKeyPair
            // 
            this.tabPageKeyPair.BackColor = System.Drawing.Color.White;
            this.tabPageKeyPair.Controls.Add(this.keysGridView1);
            this.tabPageKeyPair.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyPair.Name = "tabPageKeyPair";
            this.tabPageKeyPair.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyPair.Size = new System.Drawing.Size(1131, 469);
            this.tabPageKeyPair.TabIndex = 0;
            this.tabPageKeyPair.Text = "Key Pairs";
            // 
            // tabPageCreateKey
            // 
            this.tabPageCreateKey.BackColor = System.Drawing.Color.White;
            this.tabPageCreateKey.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateKey.Name = "tabPageCreateKey";
            this.tabPageCreateKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateKey.Size = new System.Drawing.Size(1131, 469);
            this.tabPageCreateKey.TabIndex = 1;
            this.tabPageCreateKey.Text = "Create Key Pair";
            // 
            // keysGridView1
            // 
            this.keysGridView1.BackgroundColor = System.Drawing.Color.White;
            this.keysGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keysGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.nameColumn,
            this.typeColumn,
            this.fingerprintColumn});
            this.keysGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysGridView1.Location = new System.Drawing.Point(3, 3);
            this.keysGridView1.Name = "keysGridView1";
            this.keysGridView1.Size = new System.Drawing.Size(1125, 463);
            this.keysGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "ID";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // fingerprintColumn
            // 
            this.fingerprintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fingerprintColumn.HeaderText = "Fingerprint";
            this.fingerprintColumn.Name = "fingerprintColumn";
            // 
            // KeyPairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1139, 543);
            this.ControlBox = false;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.keysTabSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyPairForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "KeyPairForm";
            this.Load += new System.EventHandler(this.KeyPairForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageKeyPair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keysGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector keysTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageKeyPair;
        private System.Windows.Forms.TabPage tabPageCreateKey;
        private System.Windows.Forms.DataGridView keysGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerprintColumn;
    }
}