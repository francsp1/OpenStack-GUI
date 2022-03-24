using MaterialSkin.Controls;
using OpenStack_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace OpenStack_GUI.Forms
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            string username = GlobalSessionDetails.Username;
            if (username != null)
            {
                this.Text = username;
            }

            try
            {
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.UnscopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + "/identity/v3/auth/projects";

                var responseString = myWebClient.DownloadString(url);

                var jo = JObject.Parse(responseString);
                var projects = jo["projects"];

                for (int i = 0; i < jo.Count; i++)
                {
                    comboBoxProjects.Items.Add(projects[i]["name"].ToString());
                }
                comboBoxProjects.SelectedIndex = 0;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error obtaining the project's list!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
