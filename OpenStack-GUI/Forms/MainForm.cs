﻿using MaterialSkin.Controls;
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
using Newtonsoft.Json;

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
                    this.Text = "User: " + username + " | " + "ID: "+ GlobalSessionDetails.UserId;
                }

                comboBoxProjects.SelectedIndex = 0;

                GlobalSessionDetails.ProjectId = getSelectedProjectId();

                if (GlobalSessionDetails.getScopedToken())
                {
                    comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);

                    fillMainTabControl();

                    this.ShowDialog();
                }

            }

        }

        private bool fillProjectsComboBox()  //Get the  project list of the user and fill the project's combo box
        {
            try
            {
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.UnscopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/identity/v3/auth/projects";

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

        private void fillMainTabControl()
        {
            fillmageServiceTab();

        }

        private void fillmageServiceTab()
        {
            //////////Images tab
            try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port +  "/image/v2/images";

                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);
                JArray images = (JArray)myObject["images"];

                imagesDataGridView.Rows.Clear();
                imagesDataGridView.Refresh();
                for (int i = 0; i < images.Count; i++)
                {
                    
                    var currentImage = images[i];
                    imagesDataGridView.Rows.Add(false, currentImage["id"].ToString(), currentImage["owner"].ToString(), currentImage["name"].ToString(), currentImage["status"].ToString(), currentImage["visibility"].ToString(), bool.Parse(currentImage["protected"].ToString()) ? "Yes" : "No", currentImage["disk_format"].ToString(), (((float)long.Parse(currentImage["size"].ToString()) / 1048576)).ToString("0.00") + "MB");

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //////////

        }

        private string getSelectedProjectId() //Get the id of the project currently selected
        {
            try
            {
                var myWebClient = new WebClient();
                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.UnscopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/identity/v3/auth/projects";

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



        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GlobalSessionDetails.ProjectId == (GlobalSessionDetails.ProjectId = getSelectedProjectId())) //if user selects the same project that was already selected
            {
                //MessageBox.Show("Entrou!!\nAntigo: " + GlobalSessionDetails.ProjectId + "\nNovo:    " + getSelectedProjectId(), "Ola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //if user select other project
            {
                //MessageBox.Show("Fazer cenas", "Ola", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (GlobalSessionDetails.getScopedToken()){ //if the token has been obtained with success
                
                    fillMainTabControl();
                }
                
            }
 
        }

        #region MaterialSkinFunctions
        private void materialSkinInitialize()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }
        #endregion MaterialSkinFunctions

        #region SecundaryEvents
        private void txtMinimumDisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void txtMinimumRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        #endregion SecundaryEvents

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}



/*
                    Models.Image image = new Models.Image();
                    
                    image.Status = currentImage["status"].ToString();
                    image.Name = currentImage["name"].ToString();
                    //image.Tags = new List<object>();
                    image.ContainerFormat = currentImage["container_format"].ToString();
                    image.CreatedAt = new DateTimeOffset(DateTime.Parse(currentImage["created_at"].ToString()));
                    image.DiskFormat = currentImage["disk_format"].ToString();
                    image.UpdatedAt = new DateTimeOffset(DateTime.Parse(currentImage["updated_at"].ToString()));
                    image.Visibility = currentImage["visibility"].ToString();
                    image.Self = currentImage["self"].ToString();
                    image.MinDisk = long.Parse(currentImage["min_disk"].ToString());
                    image.Protected = bool.Parse(currentImage["protected"].ToString());
                    image.Id = Guid.Parse(currentImage["id"].ToString());
                    image.File = currentImage["file"].ToString();
                    image.Checksum = currentImage["checksum"].ToString();
                    image.OsHashAlgo = currentImage["os_hash_algo"].ToString();
                    image.OsHashValue = currentImage["os_hash_value"].ToString();
                    image.OsHidden = bool.Parse(currentImage["os_hidden"].ToString());
                    image.Owner = currentImage["owner"].ToString();
                    image.Size = long.Parse(currentImage["size"].ToString());
                    image.MinRam = long.Parse(currentImage["min_ram"].ToString());
                    image.Schema = currentImage["schema"].ToString();
                    image.VirtualSize = currentImage["virtual_size"];
                    image.Description = currentImage["description"] == null ? null : currentImage["description"].ToString();
                    image.HwRngModel = currentImage["hw_rng_model"] == null ? null : currentImage["hw_rng_model"].ToString();
                   

                    ListViewItem item = new ListViewItem("Por definir");
                    item.SubItems.Add(currentImage["owner"].ToString());
                    item.SubItems.Add(currentImage["name"].ToString());
                    item.SubItems.Add(currentImage["status"].ToString());
                    item.SubItems.Add(currentImage["visibility"].ToString());
                    item.SubItems.Add(bool.Parse(currentImage["protected"].ToString()) ? "Yes": "No");
                    item.SubItems.Add(currentImage["disk_format"].ToString());
                    item.SubItems.Add(   (((float)long.Parse(currentImage["size"].ToString()) / 1048576)).ToString("0.00") + "MB" );

                    imagesListView.Items.Add(item);
                    */
