using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenStack_GUI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStack_GUI.Forms
{
    public partial class ImagesForm : Form
    {
        public ImagesForm()
        {
            InitializeComponent();

            fillImagesDataGridView();

            txtImageFile.Text = "C:\\Users\\franc\\Downloads\\cirros-0.4.0-x86_64-disk.img";
            txtImageName.Text = "Teste";
            txtImageDescription.Text = "T desc";


        }

        private void fillImagesDataGridView()
        {
            imagesDataGridView.Rows.Clear();
            imagesDataGridView.Refresh();

            using (WebClient myWebClient = new WebClient())
            {
                try
                { 
                    var responseJsonObject = new JObject();

                    myWebClient.Headers.Add("x-auth-token", GlobalSessionDetails.ScopedToken);

                    string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images";

                    do
                    { 
                        var responseString = myWebClient.DownloadString(url);

                        responseJsonObject = JObject.Parse(responseString);
                        JArray images = (JArray)responseJsonObject["images"];

                        for (int i = 0; i < images.Count; i++)
                        {
                            var currentImage = images[i];
                            imagesDataGridView.Rows.Add(imagesDataGridView.Rows.Count + 1, false, currentImage["id"].ToString(), currentImage["owner"].ToString(), currentImage["name"].ToString(), currentImage["status"].ToString(), currentImage["visibility"].ToString(), bool.Parse(currentImage["protected"].ToString()) ? "Yes" : "No", currentImage["disk_format"].ToString(), currentImage["container_format"].ToString(), (((float)long.Parse(currentImage["size"].ToString()) / 1048576)).ToString("0.00") + "MB", "Delete");
                        }
                        if(responseJsonObject["next"] != null)
                        {
                            url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image" + responseJsonObject["next"].ToString();
                        }

                    } while (responseJsonObject["next"] != null);  // get the images while there is a next filed in the response 
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, "Could not get the Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
                
        }

        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            string filePath = txtImageFile.Text;

            if (!File.Exists(filePath) || filePath.Length <= 0) //check if the path of the file is valid
            {
                MessageBox.Show("File is not valid! Please check if this file exists or the field is not empty", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtImageName.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please, enter a valid Image Name", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = txtImageDescription.Text;
            if (description == null || description.Length > 255)
            {
                MessageBox.Show("Please, enter a valid description", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string diskFormat = cmbBoxImageDiskFormat.Text;
            string visibility = cmbImageBoxVisibility.Text;

            string minimumDisk = txtImageMinimumDisk.Text;
            if (String.IsNullOrWhiteSpace(minimumDisk) || !int.TryParse(minimumDisk, out int it))
            {
                MessageBox.Show("Please, enter a valid disk size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string minimumRam = txtImageMinimumRam.Text;
            if (String.IsNullOrWhiteSpace(minimumRam) || !int.TryParse(minimumRam, out int it2))
            {
                MessageBox.Show("Please, enter a valid disk RAM Size", "Invalid field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool imageProtected = switchImageProtected.Checked;

            CreateImageModel image = new CreateImageModel()
            {
                Name = name,
                Desccription = description,
                DiskFormat = diskFormat.ToLower(),
                Visibility = visibility,
                MinimumDisk = int.Parse(minimumDisk),
                MinimumRam = int.Parse(minimumRam),
                Protected = imageProtected,
                ContainerFormat = "bare",
            };

            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images");

                string requestJson = JsonConvert.SerializeObject(image);
                var payload = new StringContent(requestJson, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                var result = client.PostAsync(endpoint, payload).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not create the Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var jo = JObject.Parse(json);
                var imageId = jo["id"].ToString();

                var url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId + "/file";
                
                try
                {
                    var myWebClient = new WebClient();

                    myWebClient.Headers.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);
                    myWebClient.Headers.Add("Content-Type", "application/octet-stream");


                    myWebClient.UploadFile(url, "PUT", filePath);

                    MessageBox.Show("Image created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fillImagesDataGridView();
                    imagesTabControl.SelectedTab = imagesTab;
                }
                catch (Exception excp)
                {
                    MessageBox.Show(excp.Message, "Could not upload the image file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImageBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = file.FileName;
            }


        }

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

        private void imagesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == imagesDataGridView.Columns["columnDeleteImage"].Index)
            {
                deleteImage(imagesDataGridView[2, e.RowIndex].Value.ToString());
            }
        }

        private void deleteImage(string imageId)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId);
            var client = GlobalSessionDetails._clientFactory.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

            HttpResponseMessage response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase, "Could not Delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Image deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fillImagesDataGridView();

            /*
            try
            {
                var url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageId + "\r\n";
                WebRequest request = WebRequest.Create(url);
                request.Headers.Add("x-auth-token", GlobalSessionDetails.UnscopedToken);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            var imageIdentifier = imageId;
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images/" + imageIdentifier);

                client.DefaultRequestHeaders.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);

                client.DefaultRequestHeaders.ExpectContinue = false;
                HttpResponseMessage result = client.DeleteAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.ReasonPhrase, "Could not Delete the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Image deleted with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

        }
    }
}
