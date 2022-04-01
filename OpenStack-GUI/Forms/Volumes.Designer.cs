
namespace OpenStack_GUI
{
    partial class Volumes
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.volumesTabControl.SuspendLayout();
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
            this.volumesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabSelector.Name = "volumesTabSelector";
            this.volumesTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.volumesTabSelector.TabIndex = 0;
            this.volumesTabSelector.Text = "materialTabSelector1";
            // 
            // volumesTabControl
            // 
            this.volumesTabControl.Controls.Add(this.tabPage1);
            this.volumesTabControl.Controls.Add(this.tabPage2);
            this.volumesTabControl.Depth = 0;
            this.volumesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumesTabControl.Location = new System.Drawing.Point(0, 48);
            this.volumesTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.volumesTabControl.Multiline = true;
            this.volumesTabControl.Name = "volumesTabControl";
            this.volumesTabControl.SelectedIndex = 0;
            this.volumesTabControl.Size = new System.Drawing.Size(1519, 668);
            this.volumesTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1511, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Volumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.volumesTabControl);
            this.Controls.Add(this.volumesTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Volumes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Volumes";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Volumes_Load);
            this.volumesTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector volumesTabSelector;
        private MaterialSkin.Controls.MaterialTabControl volumesTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}