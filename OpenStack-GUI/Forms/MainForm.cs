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

            materialSkinInitialize();

            if (fillProjectsComboBox()){
                string username = GlobalSessionDetails.Username;
                if (username != null)
                {
                    this.Text = username;
                }

                comboBoxProjects.SelectedIndex = 0;

                GlobalSessionDetails.ProjectId = getSelectedProjectId();

                comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);

                this.ShowDialog();
            }

        }

        private bool fillProjectsComboBox()  //Get the  project list and fill the project's combo box
        {
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
                return true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error obtaining the project's list!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string getSelectedProjectId() //Get the id of the project currently selected
        {
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
                    if (projects[i]["name"].ToString().Equals(comboBoxProjects.SelectedItem.ToString()))
                    {
                        return projects[i]["id"].ToString();
                    }
                }
                return null;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Error obtaining the project ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void materialSkinInitialize()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            //Text = DateTime.Now.ToString("dd/MM/yyyy/ss");
            var newMainForm = new MainForm();
            this.Close();
            newMainForm.ShowDialog();
            */

            if(GlobalSessionDetails.ProjectId == (GlobalSessionDetails.ProjectId = getSelectedProjectId()))
            {
                //MessageBox.Show("Entrou!!\nAntigo: " + GlobalSessionDetails.ProjectId + "\nNovo:    " + getSelectedProjectId(), "Ola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Fazer cenas", "Ola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }
    }
}
