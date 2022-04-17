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


            try
            {
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/compute/v2/" + GlobalSessionDetails.ProjectId + "/os-keypairs";
               
                var responseString = myWebClient.DownloadString(url);

                var myObject = JObject.Parse(responseString);
                JArray keys = (JArray)myObject["keypairs"];

                keysGridView1.Rows.Clear();
                keysGridView1.Refresh();

                for (int i = 0; i < myObject.Count; i++)
                {

                    var currentKey = myObject[i];

                    keysGridView1.Rows.Add(
                        currentKey["id"].ToString(),
                        currentKey["name"].ToString(),
                        currentKey["fingerprint"].ToString());
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not get the Keys Pair", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KeyPairForm_Load(object sender, EventArgs e)
        {

        }


    }
}
