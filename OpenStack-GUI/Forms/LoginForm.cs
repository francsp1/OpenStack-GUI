using MaterialSkin.Controls;
using OpenStack_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Forms
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            GlobalSessionDetails.Protocol = (string) cmbBoxProtocol.SelectedItem;

            string domain = (string)txtDomain.Text;
            if (String.IsNullOrEmpty(domain))
            {
                MessageBox.Show("Please, enter a domain/IP", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Domain = domain;
            }

            string port = (string)txtPort.Text;
            if (String.IsNullOrEmpty(port) || !int.TryParse(port, out int it) || !float.TryParse(port, out float ft))
            {
                MessageBox.Show("Please, enter a valid Port", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Port = port;
            }

            string username = (string)txtUsername.Text;
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please, enter a username", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Username = username;
            }

            string password = (string)txtPassword.Text;
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please, enter a password", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GlobalSessionDetails.Password = password;
            }


            GlobalSessionDetails.GetUnscopedToken();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
    }
}
