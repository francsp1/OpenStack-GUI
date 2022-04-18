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
    public partial class KeyPairForm : Form
    {
        public KeyPairForm()
        {
            InitializeComponent();

            refresh();
        }

        private void refresh()
        {
            keysGridView1.Rows.Clear();
            keysGridView1.Refresh();

            getKeiPairs();
        }

        private void getKeiPairs()
        {
            string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2.1/os-keypairs";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            client.DefaultRequestHeaders.ExpectContinue = false;

            var response = client.SendAsync(request).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not get the Key Pairs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject responseJsonObject = JObject.Parse(json);
            JArray keyPairs = (JArray)responseJsonObject["keypairs"];

            foreach (JToken keyPair in keyPairs)
            {
                var name = keyPair["keypair"]["name"].ToString();
                var fingerprint = keyPair["keypair"]["fingerprint"].ToString();

                keysGridView1.Rows.Add(name, fingerprint);
            }
        }


    }
}
