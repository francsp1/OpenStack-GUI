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


            try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/servers/detail";

                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);
                JArray instances = (JArray)myObject["servers"];

                instancesGridView.Rows.Clear();
                instancesGridView.Refresh();

                Console.WriteLine(instances);

                for (int i = 0; i < instances.Count; i++)
                {

                    var currentInstance = instances[i];

                    instancesGridView.Rows.Add(
                        currentInstance["id"].ToString(),
                        currentInstance["name"].ToString(),
                        currentInstance["image"].ToString(),
                        currentInstance["addresses"].ToString(),
                        currentInstance["flavor"].ToString(),
                        currentInstance["key_name"].ToString(),
                        currentInstance["OS-EXT-STS:vm_state"].ToString(),
                        currentInstance["OS-EXT-AZ:availability_zone"].ToString(),
                        currentInstance["OS-EXT-STS:task_state"].ToString(),
                        currentInstance["OS-EXT-STS:power_state"].ToString(),
                        currentInstance["OS-SRV-USG:launched_at"].ToString()
                    );
                
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Instances", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
