#region Copyright
//
// Copyright (C) 2015-2018 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// Written by M.Harada.  
// 
#endregion // Copyright

using System;
using System.Windows.Forms;
using System.Configuration; // for Configuration. Add reference to System.Configuration.
using System.Diagnostics;   // for debugging. 
using System.IO;
// Added for RestSharp. 
using RestSharp;

namespace ForgeAPIIntro
{
    /// <summary>
    /// Minimum UI to upload a model for viewing. 
    /// Workflow: 
    /// get token >> create a bucket >> upload a file >> 
    /// translate a file for viewing >> display in a browser 
    /// </summary>
    public partial class ForgeUI : Form
    {
        // To Do: set your own configuration in App.config file.
        // This is an optional one for convenience to save typing.
        private static string bucketKey = ConfigurationManager.AppSettings["bucketKey"];

        // Save access token and other data. 
        private static string m_accessToken = "";
        private static string m_fileName = "";

        public ForgeUI()
        {
            InitializeComponent();

            // An initial bucket name. 
            textBoxBucketKey.Text = bucketKey;
        }

        //=========================================================
        //  Authentication
        //=========================================================
        private void buttonToken_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            string scope = "bucket:create bucket:read data:read data:write"; 

            // Here is the main part that we call Forge authenticate. 
            m_accessToken = Forge.Authenticate(scope);

            // Show the obtained token in the form
            // Note: in real world applications, you don't expose token. 
            // This is for our learning and testing.  
            textBoxToken.Text = m_accessToken; 

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse(); 
        }

        //==========================================================
        // Helper functions 
        //==========================================================
        // Displays request and response in the text boxes.
        // This is for learning purpose. 
        private void InitRequestResponse()
        {
            // initialize the request and response text in the form.
            InitRequestResponse("Request comes here", 
                "Response comes here. This may take seconds. Please wait..."); 
        }
        private void InitRequestResponse(string req, string res)
        {
            // initialize the request and response text in the form.
            textBoxRequest.Text = req;
            labelStatus.Text = "";
            textBoxResponse.Text = res;
        }
        private void ShowRequestResponse()
        {
            // show the request and response in the form. 
            IRestResponse response = Forge.m_lastResponse;
            textBoxRequest.Text = response.ResponseUri.AbsoluteUri;
            labelStatus.Text = "Status: " + response.StatusCode.ToString();
            textBoxResponse.Text = response.Content;
        }

        //==========================================================
        // Bucket 
        //==========================================================
        private void buttonBucketCreate_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            string bucketKey = textBoxBucketKey.Text;
            string policyKey = "transient"; // transient(24h)/temporary(30 days)/persistent 

            // Here is the main part that we call Forge API for bucket creation.
            // Return true if success, false otherwise.   
            bool result = Forge.CreateBucket(m_accessToken, bucketKey, policyKey);

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse(); 
        }

        private void buttonBucketDetails_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();
            
            string bucketKey = textBoxBucketKey.Text; 

            // Here is the main part that we call Forge API bucket details.
            // Return value is bucket detail.   
            string details = Forge.GetBucketDetails(m_accessToken, bucketKey);

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse();
        }

        //==========================================================
        // Upload 
        //==========================================================
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            // Set the data needed to upload. 
            string bucketKey = textBoxBucketKey.Text;
            string path = textBoxFile.Text;
            string objectName = m_fileName;
            byte[] fileData = File.ReadAllBytes(path);

            // Here is the main part that we call Forge API upload  
            string objectId = Forge.Upload(m_accessToken, bucketKey, objectName, fileData);

            // show the objectId = urn:xxx on the form. 
            textBoxObjectId.Text = objectId; // "urn:xxx"

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse(); 
        }

        // Choose a file to upload. No REST call with this button. 
        //
        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = fileDialog.FileName;  // full path 
                m_fileName = fileDialog.SafeFileName;    // file name only   
            }
        }

        // Shows a list of objects in the bucket. 
        private void buttonObjects_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            string bucketKey = textBoxBucketKey.Text;

            // Here is the main part that we call Forge API bucket objects.
            // Returns a list of bucket objects. 
            string bucketObjects = Forge.GetBucketObjects(m_accessToken, bucketKey);

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse();
        }

        //==========================================================
        // Translation
        //==========================================================

        // Convert objectId (or source urn) to Base64 encoded urn. 
        // This is an utility. Not using Forge API itself. 
        private void buttonToUrn64_Click(object sender, EventArgs e)
        {
            // clear UI. This does not call Forge API
            InitRequestResponse("Convert ObjectId to Base64 encoded urn.", "");
            this.Update();

            // Convert objectId (=source urn) to base64 encoded urn. 
            string objectId = textBoxObjectId.Text;
            string urn64 = Forge.ObjectIdToUrn64(objectId);

            // show the urn64 in the form. 
            textBoxUrn64.Text = urn64;

        }
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            string urn64 = textBoxUrn64.Text; 

            // Here is the main part that we call Forge API to translate 
            // the file for viewing.  
            bool result = Forge.Translate(m_accessToken, urn64);

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse(); 
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            InitRequestResponse();
            this.Update();

            string urn64 = textBoxUrn64.Text;

            // Here is the main part that we call Forge API to check 
            // the status of translation.
            // Possible value of status: pending/success/inprogress/failed/timeout.    
            string status = Forge.GetManifest(m_accessToken, urn64);

            // For our learning, 
            // show the request and response in the form. 
            ShowRequestResponse();
        }

        //==========================================================
        // Viewer
        //==========================================================
        // Starts a web browser with a viewer.
        // Note: Forge Viewer is intended to work with a modern web browser.
        // WebBrowser control in Win Form does not support it.
        // Here we simply lauch a default browser to display as a local html file.  
        // We'll come back to the Viewer portion in the later lab.   
        private void buttonView_Click(object sender, EventArgs e)
        {
            // Clear UI. This does not call Forge API
            InitRequestResponse("Launching a viewer in a web browser...", "");
            this.Update();

            // Make a minimum html file with a Forge viewer embeded.
             
            // What we need are two values: token and urn.
            string token = m_accessToken;
            string urn = textBoxUrn64.Text;

            // For simplicity, we use a html file provided as a template, 
            // and simply replace two variables with real values.

            string template = @"ViewerTemplate.html";
            string fileName = @"Viewer.html";

            string text = File.ReadAllText(template);
            text = text.Replace("__yourToken__", token);
            text = text.Replace("__yourUrn__", urn);
            File.WriteAllText(fileName, text);

            // Launch a default browser 
            Process.Start(fileName); 
        }

    }
}
