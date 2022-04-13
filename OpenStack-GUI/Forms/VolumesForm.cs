using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Forms
{
    public partial class VolumesForm : Form
    {
        public VolumesForm()
        {
            InitializeComponent();

            volumesTabControl.TabPages.Remove(tabPage3);

            refresh();
        }

        private void refresh()
        {
            volumesGridView.Rows.Clear();
            volumesGridView.Refresh();


            try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/volume/v3/" + GlobalSessionDetails.ProjectId + "/volumes/detail";

                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);
                JArray volumes = (JArray)myObject["volumes"];

                volumesGridView.Rows.Clear();
                volumesGridView.Refresh();

                for (int i = 0; i < volumes.Count; i++)
                {

                    var currentVolume = volumes[i];

                    //var attach = currentVolume["attachments"][0];
                    if (currentVolume["name"].ToString() == "")
                    {
                        volumesGridView.Rows.Add(currentVolume["id"].ToString(), currentVolume["id"].ToString(), currentVolume["description"].ToString(), currentVolume["size"].ToString() + " GiB",
                        currentVolume["status"].ToString(), currentVolume["consistencygroup_id"].ToString(), currentVolume["volume_type"].ToString(),
                        currentVolume["availability_zone"].ToString(), bool.Parse(currentVolume["bootable"].ToString()) ? "Yes" : "No",
                        bool.Parse(currentVolume["encrypted"].ToString()) ? "Yes" : "No");
                    }
                    else
                    {
                        volumesGridView.Rows.Add(currentVolume["id"].ToString(), currentVolume["name"].ToString(), currentVolume["description"].ToString(), currentVolume["size"].ToString() + " GiB",
                        currentVolume["status"].ToString(), currentVolume["consistencygroup_id"].ToString(), currentVolume["volume_type"].ToString(),
                        currentVolume["availability_zone"].ToString(), bool.Parse(currentVolume["bootable"].ToString()) ? "Yes" : "No",
                        bool.Parse(currentVolume["encrypted"].ToString()) ? "Yes" : "No");
                    }
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Volumes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Volumes_Load(object sender, EventArgs e)
        {

        }

        private void CreateVolumeButton_Click(object sender, EventArgs e)
        {
            string name = VolumeTextBox.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Volume Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = DescriptionTextBox.Text;
            if (String.IsNullOrWhiteSpace((description)))
            {
                MessageBox.Show("Please, enter a valid Description", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string source = sourceComboBox.Text;
            string type = TypeComboBox.Text;

            string size = sizeTextBox.Text;
            if (String.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Please, enter a valid Size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string availabilityZone = availabilityComboBox.Text;

            Volume volume = new Volume
            {
                volume = new

                CreateVolumesModel()
                {
                    Name = name,
                    Description = description,
                    Source = source,
                    Type = type,
                    Size = size,
                    AvailabilityZone = availabilityZone
                }
            };

            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/volume/v3/" + GlobalSessionDetails.ProjectId + "/volumes");

                string requestJson = JsonConvert.SerializeObject(volume);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.PostAsync(endpoint, payload).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                MessageBox.Show("Volume created sucessesfully", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                volumesTabControl.SelectedTab = tabPage1;

                refresh();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == volumesGridView.Columns["edit"].Index)
            {
                //editVolume(e.RowIndex);
                updateVolume(volumesGridView[0, e.RowIndex].Value.ToString());
            }

            if (e.ColumnIndex == volumesGridView.Columns["delete"].Index)
            {

                deleteVolume(volumesGridView[0, e.RowIndex].Value.ToString());
            }
        }

        private void deleteVolume(string volumeID)
        {
            //var volumeIdentifier = volumeID;
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/volume/v3/" + GlobalSessionDetails.ProjectId + "/volumes/" + volumeID);

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.DeleteAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not Delete the Volume", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Volume deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            refresh();
        }

        private void btnUpdateVolume_Click(object sender, EventArgs e)
        {
            string name = editTextBoxName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Image Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string description = editTextBoxDesc.Text;
            if (description == null || description.Length > 255)
            {
                MessageBox.Show("Please, enter a valid description", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool volumeBoot = switchEditBoot.Checked;

            //???
            updateVolume("");

            btnCancelEditVolume_Click(null, null);

            volumesTabControl.TabPages.Remove(tabPage3);
        }

        private void updateVolume(string volumeID)
        {
            int rowIndex = 0;

            if (!volumesTabControl.TabPages.Contains(tabPage3))
            {
                volumesTabControl.TabPages.Add(tabPage3);
            }
            volumesTabControl.SelectedTab = tabPage3;

            var selectedRow = volumesGridView.Rows[rowIndex].Cells;

            editTextBoxName.Text = selectedRow[1].Value.ToString();
            editTextBoxDesc.Text = selectedRow[2].Value.ToString();

            switchEditBoot.Checked = selectedRow[8].Value.ToString() == "Yes" ? true : false;

            Volume volume = new Volume
            {
                volume = new

                CreateVolumesModel()
                {
                    Name = editTextBoxName.Text,
                    Description = editTextBoxDesc.Text
                }
            };

            var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/volume/v3/" + GlobalSessionDetails.ProjectId + "/volumes/" + volumeID);

            var client = GlobalSessionDetails._clientFactory.CreateClient();

            var httpVerb = new HttpMethod("PUT");

            string requestJson = JsonConvert.SerializeObject(volume);
            var payload = new StringContent(requestJson, Encoding.UTF8, "application/openstack-images-v2.1-json-patch");

            var httpRequestMessage = new HttpRequestMessage(httpVerb, endpoint)
            {
                Content = payload,
            };

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);
            client.DefaultRequestHeaders.ExpectContinue = false;

            HttpResponseMessage response = client.SendAsync(httpRequestMessage).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Update the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Image updated with success", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelEditVolume_Click(object sender, EventArgs e)
        {
            editTextBoxName.Text = "";
            editTextBoxDesc.Text = "";
            switchEditBoot.Checked = false;
            volumesTabControl.TabPages.Remove(tabPage3);
        }
    }
}
