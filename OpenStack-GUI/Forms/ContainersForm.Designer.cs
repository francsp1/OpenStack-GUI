
namespace OpenStack_GUI.Forms
{
    partial class ContainersForm
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
            this.containersTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.containersTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.containersTabPage = new System.Windows.Forms.TabPage();
            this.createContainerTabPage = new System.Windows.Forms.TabPage();
            this.containersTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // containersTabSelector
            // 
            this.containersTabSelector.BaseTabControl = this.containersTabControl;
            this.containersTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.containersTabSelector.Depth = 0;
            this.containersTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.containersTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.containersTabSelector.Location = new System.Drawing.Point(0, 0);
            this.containersTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.containersTabSelector.Name = "containersTabSelector";
            this.containersTabSelector.Size = new System.Drawing.Size(1519, 48);
            this.containersTabSelector.TabIndex = 0;
            // 
            // containersTabControl
            // 
            this.containersTabControl.Controls.Add(this.containersTabPage);
            this.containersTabControl.Controls.Add(this.createContainerTabPage);
            this.containersTabControl.Depth = 0;
            this.containersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containersTabControl.Location = new System.Drawing.Point(0, 48);
            this.containersTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.containersTabControl.Multiline = true;
            this.containersTabControl.Name = "containersTabControl";
            this.containersTabControl.SelectedIndex = 0;
            this.containersTabControl.Size = new System.Drawing.Size(1519, 668);
            this.containersTabControl.TabIndex = 1;
            // 
            // containersTabPage
            // 
            this.containersTabPage.Location = new System.Drawing.Point(4, 25);
            this.containersTabPage.Name = "containersTabPage";
            this.containersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.containersTabPage.Size = new System.Drawing.Size(1511, 639);
            this.containersTabPage.TabIndex = 0;
            this.containersTabPage.Text = "Containers";
            this.containersTabPage.UseVisualStyleBackColor = true;
            // 
            // createContainerTabPage
            // 
            this.createContainerTabPage.Location = new System.Drawing.Point(4, 25);
            this.createContainerTabPage.Name = "createContainerTabPage";
            this.createContainerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createContainerTabPage.Size = new System.Drawing.Size(1511, 639);
            this.createContainerTabPage.TabIndex = 1;
            this.createContainerTabPage.Text = "Create Container";
            this.createContainerTabPage.UseVisualStyleBackColor = true;
            // 
            // ContainersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 716);
            this.ControlBox = false;
            this.Controls.Add(this.containersTabControl);
            this.Controls.Add(this.containersTabSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContainersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.White;
            this.containersTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector containersTabSelector;
        private MaterialSkin.Controls.MaterialTabControl containersTabControl;
        private System.Windows.Forms.TabPage containersTabPage;
        private System.Windows.Forms.TabPage createContainerTabPage;
    }
}