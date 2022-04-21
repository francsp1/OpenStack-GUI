using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Forms
{
    public partial class ContainersForm : Form
    {
        public ContainersForm()
        {
            InitializeComponent();

            //containersTabControl.TabPages.Remove(editContainerTab);

            fillContainersDataGridView();

        }

        private void fillContainersDataGridView()
        {
            containersGridView.Rows.Clear();
            containersGridView.Refresh(); ;

            getContainers();
        }

        private void getContainers()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container/v1/containers/";

            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            var responseJsonObject = new JObject();
            do
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                HttpResponseMessage response = client.SendAsync(request).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(response.ReasonPhrase, "Could not get the Containers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                responseJsonObject = JObject.Parse(responseString);
                JArray containers = (JArray)responseJsonObject["containers"];

                for (int i = 0; i < containers.Count; i++)
                {
                    var currentContainer = containers[i];

                    containersGridView.Rows.Add(
                            string.IsNullOrWhiteSpace(currentContainer["name"].ToString())         ? "-"    : currentContainer["name"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["uuid"].ToString())         ? "-"    : currentContainer["uuid"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["image"].ToString())        ? "-"    : currentContainer["image"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["status"].ToString())       ? "-"    : currentContainer["status"].ToString(),
                            string.IsNullOrWhiteSpace(currentContainer["task_state"].ToString())   ? "-"    : currentContainer["task_state"].ToString()
                        );
                }
                var teste = responseJsonObject["next"].ToString();
                if (responseJsonObject["next"].ToString() != "")
                {
                    url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/container" + responseJsonObject["next"].ToString();
                }

            } while (responseJsonObject["next"].ToString() != "");  // get the containers while there is a next filed in the response 

        }
    }
}
