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

            //instancesGridView.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //instancesGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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

                JObject addresses = (JObject) myObject["servers"][0]["addresses"];

                instancesGridView.Rows.Clear();
                instancesGridView.Refresh();

                for (int i = 0; i < instances.Count; i++)
                {

                    var currentInstance = instances[i];

                    var task = currentInstance["OS-EXT-STS:task_state"].ToString();

                    if (task == "")
                    {
                        task = "None";
                    }

                    var powerState = currentInstance["OS-EXT-STS:power_state"].ToString();

                    if (powerState == "1")
                    {
                        powerState = "Running";
                    }
                    else if (powerState == "0")
                    {
                        powerState = "Not Running";
                    }

                    var lauched = Convert.ToDateTime(currentInstance["OS-SRV-USG:launched_at"].ToString());
                    DateTime date = DateTime.Now;
                    var age = Convert.ToInt32((date - lauched).Days);

                    var weeks = (age % 365) / 7;
                    var days = (age % 365) % 7;
                    var final = (weeks + " Weeks," + days + " Days");

                    var flavor = currentInstance["flavor"]["links"][0]["href"].ToString();
                    if (flavor == currentInstance["flavor"]["links"][0]["href"].ToString())
                    {
                        flavor = "m1.nano";
                    }

                    //var ipv4 = currentInstance["addresses"]["private"][0]["addr"].ToString();

                    string ips = "";
                    JObject addressesObject = JObject.Parse(currentInstance["addresses"].ToString());

                    foreach (var network in addressesObject)
                    {
                        var networkName = network.Key;
                        ips = ips + "Network: " + networkName + "\n";
                        foreach (var address in network.Value)
                        {

                            var version = address["version"].ToString();
                            var addr = address["addr"].ToString();

                            ips = ips + addr + "\n";
                        }
                    }

                    instancesGridView.Rows.Add(
                        currentInstance["id"].ToString(),
                        currentInstance["name"].ToString(),
                        currentInstance["image"].ToString(),
                        ips,
                        flavor.ToString(),
                        currentInstance["key_name"].ToString(),
                        currentInstance["OS-EXT-STS:vm_state"].ToString(),
                        currentInstance["OS-EXT-AZ:availability_zone"].ToString(),
                        task.ToString(),
                        powerState.ToString(),
                        final.ToString()
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
