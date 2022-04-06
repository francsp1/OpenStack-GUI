﻿using Newtonsoft.Json;
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

            txtImageFile.Text = "C:\\Users\\franc\\Downloads\\cirros-0.4.0-x86_64-disk.img";
            txtImageName.Text = "Teste";
            txtImageDescription.Text = "T desc";


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

            try
            {
                string requestJson = JsonConvert.SerializeObject(image);

                string url = GlobalSessionDetails.Protocol + "://" + GlobalSessionDetails.Domain + ":" + GlobalSessionDetails.Port + "/image/v2/images";

                
                WebClient myWebClient = new WebClient();

                myWebClient.Headers.Add("X-Auth-Token", GlobalSessionDetails.ScopedToken);
                myWebClient.Headers.Add("Content-Type", "application/json");
                //myWebClient.Headers[HttpRequestHeader.ContentType] = "application/json";

                var responseString = myWebClient.UploadString(url, requestJson);

                MessageBox.Show("Image created with success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Could not create the Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}