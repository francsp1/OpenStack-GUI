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
    public partial class InstancesForm : Form
    {
        public InstancesForm()
        {
            InitializeComponent();

            refresh();
        }

        private void refresh()
        {
            instancesGridView.Rows.Clear();
            instancesGridView.Refresh();


           /* try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/servers/detail";

                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);
                JArray instances = (JArray)myObject["instances"];

                instancesGridView.Rows.Clear();
                instancesGridView.Refresh();

                for (int i = 0; i < instances.Count; i++)
                {

                    var currentVolume = instances[i];

                    instancesGridView.Rows.Add(currentVolume["id"].ToString(),
                        currentVolume["name"].ToString(),
                        currentVolume["image"].ToString(),
                        currentVolume["addresses"][0][1].ToString(),
                        currentVolume["flavor"].ToString(),
                        currentVolume["key_name"].ToString(),
                        currentVolume["OS-EXT-STS:vm_state"].ToString(),
                        currentVolume["OS-EXT-AZ:availability_zone"].ToString(),
                        currentVolume["OS-EXT-STS:task_state"].ToString(),
                        currentVolume["OS-EXT-STS:power_state"].ToString(),
                        currentVolume["OS-SRV-USG:launched_at"].ToString()
                    );
                
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Volumes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
