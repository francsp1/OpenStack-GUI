using Newtonsoft.Json.Linq;
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

namespace OpenStack_GUI.Forms
{
    public partial class VolumesForm : Form
    {
        public VolumesForm()
        {
            InitializeComponent();

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

                    volumesGridView.Rows.Add(false, currentVolume["name"].ToString(), currentVolume["description"].ToString(), currentVolume["size"].ToString() + " GiB", 
                        currentVolume["status"].ToString(), currentVolume["metadata"].ToString(), currentVolume["volume_type"].ToString(),
                        currentVolume["availability_zone"].ToString(), bool.Parse(currentVolume["bootable"].ToString()) ? "Yes" : "No", 
                        bool.Parse(currentVolume["encrypted"].ToString()) ? "Yes" : "No");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
