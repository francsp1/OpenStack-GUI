
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
            this.keysGridView1 = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerprintColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCreateKey = new System.Windows.Forms.TabPage();
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
            this.keysTabSelector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keysTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.keysTabSelector1.Name = "keysTabSelector1";
            this.keysTabSelector1.Size = new System.Drawing.Size(1519, 48);
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
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1519, 620);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPageKeyPair
            // 
            this.tabPageKeyPair.BackColor = System.Drawing.Color.White;
            this.tabPageKeyPair.Controls.Add(this.keysGridView1);
            this.tabPageKeyPair.Location = new System.Drawing.Point(4, 25);
            this.tabPageKeyPair.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageKeyPair.Name = "tabPageKeyPair";
            this.tabPageKeyPair.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageKeyPair.Size = new System.Drawing.Size(1511, 591);
            this.tabPageKeyPair.TabIndex = 0;
            this.tabPageKeyPair.Text = "Key Pairs";
            // 
            // keysGridView1
            // 
            this.keysGridView1.AllowUserToAddRows = false;
            this.keysGridView1.BackgroundColor = System.Drawing.Color.White;
            this.keysGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keysGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keysGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.fingerprintColumn});
            this.keysGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysGridView1.Location = new System.Drawing.Point(4, 4);
            this.keysGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.keysGridView1.Name = "keysGridView1";
            this.keysGridView1.RowHeadersWidth = 51;
            this.keysGridView1.Size = new System.Drawing.Size(1503, 583);
            this.keysGridView1.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            // 
            // fingerprintColumn
            // 
            this.fingerprintColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fingerprintColumn.HeaderText = "Fingerprint";
            this.fingerprintColumn.MinimumWidth = 6;
            this.fingerprintColumn.Name = "fingerprintColumn";
            // 
            // tabPageCreateKey
            // 
            this.tabPageCreateKey.BackColor = System.Drawing.Color.White;
            this.tabPageCreateKey.Location = new System.Drawing.Point(4, 25);
            this.tabPageCreateKey.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCreateKey.Name = "tabPageCreateKey";
            this.tabPageCreateKey.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCreateKey.Size = new System.Drawing.Size(1511, 580);
            this.tabPageCreateKey.TabIndex = 1;
            this.tabPageCreateKey.Text = "Create Key Pair";
            // 
            // KeyPairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1519, 668);
            this.ControlBox = false;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.keysTabSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyPairForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "KeyPairForm";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerprintColumn;
    }
}