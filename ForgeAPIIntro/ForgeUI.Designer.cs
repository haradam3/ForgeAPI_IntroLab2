namespace ForgeAPIIntro
{
    partial class ForgeUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonToken = new System.Windows.Forms.Button();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.buttonBucketCreate = new System.Windows.Forms.Button();
            this.textBoxBucketKey = new System.Windows.Forms.TextBox();
            this.labelBucket = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxObjectId = new System.Windows.Forms.TextBox();
            this.labelObjectId = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.labelUrn64 = new System.Windows.Forms.Label();
            this.textBoxUrn64 = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonBucketDetails = new System.Windows.Forms.Button();
            this.buttonObjects = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.groupBoxAuthentication = new System.Windows.Forms.GroupBox();
            this.groupOSS = new System.Windows.Forms.GroupBox();
            this.groupBoxDerivative = new System.Windows.Forms.GroupBox();
            this.buttonToUrn64 = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.groupBoxAuthentication.SuspendLayout();
            this.groupOSS.SuspendLayout();
            this.groupBoxDerivative.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonToken
            // 
            this.buttonToken.Location = new System.Drawing.Point(432, 26);
            this.buttonToken.Name = "buttonToken";
            this.buttonToken.Size = new System.Drawing.Size(80, 25);
            this.buttonToken.TabIndex = 0;
            this.buttonToken.Text = "Get Token";
            this.buttonToken.UseVisualStyleBackColor = true;
            this.buttonToken.Click += new System.EventHandler(this.buttonToken_Click);
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(28, 332);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(389, 65);
            this.textBoxRequest.TabIndex = 1;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(28, 431);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(389, 94);
            this.textBoxResponse.TabIndex = 2;
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(28, 308);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(61, 17);
            this.labelRequest.TabIndex = 3;
            this.labelRequest.Text = "Request";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(28, 410);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(72, 17);
            this.labelResponse.TabIndex = 4;
            this.labelResponse.Text = "Response";
            // 
            // buttonBucketCreate
            // 
            this.buttonBucketCreate.Location = new System.Drawing.Point(432, 21);
            this.buttonBucketCreate.Name = "buttonBucketCreate";
            this.buttonBucketCreate.Size = new System.Drawing.Size(80, 25);
            this.buttonBucketCreate.TabIndex = 5;
            this.buttonBucketCreate.Text = "Create";
            this.buttonBucketCreate.UseVisualStyleBackColor = true;
            this.buttonBucketCreate.Click += new System.EventHandler(this.buttonBucketCreate_Click);
            // 
            // textBoxBucketKey
            // 
            this.textBoxBucketKey.Location = new System.Drawing.Point(117, 21);
            this.textBoxBucketKey.Name = "textBoxBucketKey";
            this.textBoxBucketKey.Size = new System.Drawing.Size(275, 22);
            this.textBoxBucketKey.TabIndex = 6;
            // 
            // labelBucket
            // 
            this.labelBucket.AutoSize = true;
            this.labelBucket.Location = new System.Drawing.Point(51, 21);
            this.labelBucket.Name = "labelBucket";
            this.labelBucket.Size = new System.Drawing.Size(51, 17);
            this.labelBucket.TabIndex = 7;
            this.labelBucket.Text = "Bucket";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(432, 60);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(80, 25);
            this.buttonUpload.TabIndex = 8;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(432, 59);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(80, 25);
            this.buttonTranslate.TabIndex = 9;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(117, 62);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(275, 22);
            this.textBoxFile.TabIndex = 10;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(51, 64);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(30, 17);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "File";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(392, 60);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(28, 25);
            this.buttonFile.TabIndex = 12;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxObjectId
            // 
            this.textBoxObjectId.Location = new System.Drawing.Point(117, 23);
            this.textBoxObjectId.Name = "textBoxObjectId";
            this.textBoxObjectId.Size = new System.Drawing.Size(275, 22);
            this.textBoxObjectId.TabIndex = 13;
            // 
            // labelObjectId
            // 
            this.labelObjectId.AutoSize = true;
            this.labelObjectId.Location = new System.Drawing.Point(51, 26);
            this.labelObjectId.Name = "labelObjectId";
            this.labelObjectId.Size = new System.Drawing.Size(64, 17);
            this.labelObjectId.TabIndex = 14;
            this.labelObjectId.Text = "Object Id";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(117, 28);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(275, 22);
            this.textBoxToken.TabIndex = 15;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(51, 26);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(48, 17);
            this.labelToken.TabIndex = 16;
            this.labelToken.Text = "Token";
            // 
            // labelUrn64
            // 
            this.labelUrn64.AutoSize = true;
            this.labelUrn64.Location = new System.Drawing.Point(51, 63);
            this.labelUrn64.Name = "labelUrn64";
            this.labelUrn64.Size = new System.Drawing.Size(45, 17);
            this.labelUrn64.TabIndex = 17;
            this.labelUrn64.Text = "urn64";
            // 
            // textBoxUrn64
            // 
            this.textBoxUrn64.Location = new System.Drawing.Point(117, 60);
            this.textBoxUrn64.Name = "textBoxUrn64";
            this.textBoxUrn64.Size = new System.Drawing.Size(275, 22);
            this.textBoxUrn64.TabIndex = 18;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(118, 410);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            this.labelStatus.TabIndex = 19;
            // 
            // buttonBucketDetails
            // 
            this.buttonBucketDetails.Location = new System.Drawing.Point(525, 21);
            this.buttonBucketDetails.Name = "buttonBucketDetails";
            this.buttonBucketDetails.Size = new System.Drawing.Size(80, 25);
            this.buttonBucketDetails.TabIndex = 20;
            this.buttonBucketDetails.Text = "Details";
            this.buttonBucketDetails.UseVisualStyleBackColor = true;
            this.buttonBucketDetails.Click += new System.EventHandler(this.buttonBucketDetails_Click);
            // 
            // buttonObjects
            // 
            this.buttonObjects.Location = new System.Drawing.Point(525, 60);
            this.buttonObjects.Name = "buttonObjects";
            this.buttonObjects.Size = new System.Drawing.Size(80, 25);
            this.buttonObjects.TabIndex = 21;
            this.buttonObjects.Text = "Objects";
            this.buttonObjects.UseVisualStyleBackColor = true;
            this.buttonObjects.Click += new System.EventHandler(this.buttonObjects_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(525, 59);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(80, 25);
            this.buttonStatus.TabIndex = 22;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // groupBoxAuthentication
            // 
            this.groupBoxAuthentication.Controls.Add(this.labelToken);
            this.groupBoxAuthentication.Controls.Add(this.textBoxToken);
            this.groupBoxAuthentication.Controls.Add(this.buttonToken);
            this.groupBoxAuthentication.Location = new System.Drawing.Point(10, 10);
            this.groupBoxAuthentication.Name = "groupBoxAuthentication";
            this.groupBoxAuthentication.Size = new System.Drawing.Size(620, 64);
            this.groupBoxAuthentication.TabIndex = 23;
            this.groupBoxAuthentication.TabStop = false;
            this.groupBoxAuthentication.Text = "Authentication";
            // 
            // groupOSS
            // 
            this.groupOSS.Controls.Add(this.buttonObjects);
            this.groupOSS.Controls.Add(this.buttonBucketDetails);
            this.groupOSS.Controls.Add(this.buttonFile);
            this.groupOSS.Controls.Add(this.labelFile);
            this.groupOSS.Controls.Add(this.textBoxFile);
            this.groupOSS.Controls.Add(this.buttonUpload);
            this.groupOSS.Controls.Add(this.labelBucket);
            this.groupOSS.Controls.Add(this.textBoxBucketKey);
            this.groupOSS.Controls.Add(this.buttonBucketCreate);
            this.groupOSS.Location = new System.Drawing.Point(10, 90);
            this.groupOSS.Name = "groupOSS";
            this.groupOSS.Size = new System.Drawing.Size(620, 96);
            this.groupOSS.TabIndex = 24;
            this.groupOSS.TabStop = false;
            this.groupOSS.Text = "OSS";
            // 
            // groupBoxDerivative
            // 
            this.groupBoxDerivative.Controls.Add(this.buttonToUrn64);
            this.groupBoxDerivative.Controls.Add(this.buttonStatus);
            this.groupBoxDerivative.Controls.Add(this.textBoxUrn64);
            this.groupBoxDerivative.Controls.Add(this.labelUrn64);
            this.groupBoxDerivative.Controls.Add(this.labelObjectId);
            this.groupBoxDerivative.Controls.Add(this.textBoxObjectId);
            this.groupBoxDerivative.Controls.Add(this.buttonTranslate);
            this.groupBoxDerivative.Location = new System.Drawing.Point(10, 200);
            this.groupBoxDerivative.Name = "groupBoxDerivative";
            this.groupBoxDerivative.Size = new System.Drawing.Size(620, 99);
            this.groupBoxDerivative.TabIndex = 25;
            this.groupBoxDerivative.TabStop = false;
            this.groupBoxDerivative.Text = "Derivative";
            // 
            // buttonToUrn64
            // 
            this.buttonToUrn64.Location = new System.Drawing.Point(432, 19);
            this.buttonToUrn64.Name = "buttonToUrn64";
            this.buttonToUrn64.Size = new System.Drawing.Size(80, 25);
            this.buttonToUrn64.TabIndex = 23;
            this.buttonToUrn64.Text = "To urn64";
            this.buttonToUrn64.UseVisualStyleBackColor = true;
            this.buttonToUrn64.Click += new System.EventHandler(this.buttonToUrn64_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(442, 332);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(80, 25);
            this.buttonView.TabIndex = 26;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // ForgeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 542);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.groupBoxDerivative);
            this.Controls.Add(this.groupOSS);
            this.Controls.Add(this.groupBoxAuthentication);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.textBoxRequest);
            this.Name = "ForgeUI";
            this.Text = "Forge API Intro";
            this.groupBoxAuthentication.ResumeLayout(false);
            this.groupBoxAuthentication.PerformLayout();
            this.groupOSS.ResumeLayout(false);
            this.groupOSS.PerformLayout();
            this.groupBoxDerivative.ResumeLayout(false);
            this.groupBoxDerivative.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToken;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button buttonBucketCreate;
        private System.Windows.Forms.TextBox textBoxBucketKey;
        private System.Windows.Forms.Label labelBucket;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxObjectId;
        private System.Windows.Forms.Label labelObjectId;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label labelUrn64;
        private System.Windows.Forms.TextBox textBoxUrn64;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonBucketDetails;
        private System.Windows.Forms.Button buttonObjects;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.GroupBox groupBoxAuthentication;
        private System.Windows.Forms.GroupBox groupOSS;
        private System.Windows.Forms.GroupBox groupBoxDerivative;
        private System.Windows.Forms.Button buttonToUrn64;
        private System.Windows.Forms.Button buttonView;
    }
}

