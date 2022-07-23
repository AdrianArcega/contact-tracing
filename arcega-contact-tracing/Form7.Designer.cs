namespace arcega_contact_tracing
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblScanQR = new System.Windows.Forms.Label();
            this.cboxCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picbxCam = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblFullName1 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.txtbxDateOfVisit1 = new System.Windows.Forms.TextBox();
            this.lblDateOfVisit1 = new System.Windows.Forms.Label();
            this.txtbxFullName1 = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelFullName1 = new System.Windows.Forms.Label();
            this.timerQR = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScanQR
            // 
            this.lblScanQR.AutoSize = true;
            this.lblScanQR.BackColor = System.Drawing.Color.Transparent;
            this.lblScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanQR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScanQR.Location = new System.Drawing.Point(336, 18);
            this.lblScanQR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanQR.Name = "lblScanQR";
            this.lblScanQR.Size = new System.Drawing.Size(250, 46);
            this.lblScanQR.TabIndex = 1;
            this.lblScanQR.Text = "QR Scanner";
            this.lblScanQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboxCamera
            // 
            this.cboxCamera.FormattingEnabled = true;
            this.cboxCamera.Location = new System.Drawing.Point(308, 107);
            this.cboxCamera.Name = "cboxCamera";
            this.cboxCamera.Size = new System.Drawing.Size(312, 24);
            this.cboxCamera.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(408, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picbxCam
            // 
            this.picbxCam.BackColor = System.Drawing.SystemColors.Control;
            this.picbxCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxCam.Location = new System.Drawing.Point(213, 137);
            this.picbxCam.Name = "picbxCam";
            this.picbxCam.Size = new System.Drawing.Size(502, 462);
            this.picbxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbxCam.TabIndex = 4;
            this.picbxCam.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(344, 685);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(242, 41);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRunClick);
            // 
            // lblFullName1
            // 
            this.lblFullName1.AccessibleName = "";
            this.lblFullName1.AutoSize = true;
            this.lblFullName1.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblFullName1.Location = new System.Drawing.Point(152, 617);
            this.lblFullName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName1.Name = "lblFullName1";
            this.lblFullName1.Size = new System.Drawing.Size(247, 24);
            this.lblFullName1.TabIndex = 72;
            this.lblFullName1.Text = "FN                  MI               SN";
            this.lblFullName1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate1
            // 
            this.lblDate1.AccessibleName = "";
            this.lblDate1.AutoSize = true;
            this.lblDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate1.Location = new System.Drawing.Point(699, 617);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(140, 24);
            this.lblDate1.TabIndex = 71;
            this.lblDate1.Text = "(MM-DD-YYYY)";
            this.lblDate1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxDateOfVisit1
            // 
            this.txtbxDateOfVisit1.Location = new System.Drawing.Point(691, 643);
            this.txtbxDateOfVisit1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxDateOfVisit1.Name = "txtbxDateOfVisit1";
            this.txtbxDateOfVisit1.Size = new System.Drawing.Size(167, 22);
            this.txtbxDateOfVisit1.TabIndex = 70;
            // 
            // lblDateOfVisit1
            // 
            this.lblDateOfVisit1.AccessibleName = "";
            this.lblDateOfVisit1.AutoSize = true;
            this.lblDateOfVisit1.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfVisit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfVisit1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDateOfVisit1.Location = new System.Drawing.Point(525, 641);
            this.lblDateOfVisit1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfVisit1.Name = "lblDateOfVisit1";
            this.lblDateOfVisit1.Size = new System.Drawing.Size(153, 24);
            this.lblDateOfVisit1.TabIndex = 69;
            this.lblDateOfVisit1.Text = "DATE OF VISIT :";
            this.lblDateOfVisit1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxFullName1
            // 
            this.txtbxFullName1.Location = new System.Drawing.Point(155, 643);
            this.txtbxFullName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFullName1.Name = "txtbxFullName1";
            this.txtbxFullName1.Size = new System.Drawing.Size(349, 22);
            this.txtbxFullName1.TabIndex = 68;
            // 
            // labelFullName
            // 
            this.labelFullName.AccessibleName = "";
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelFullName.Location = new System.Drawing.Point(-149, 632);
            this.labelFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(126, 24);
            this.labelFullName.TabIndex = 67;
            this.labelFullName.Text = "FULL NAME :";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFullName1
            // 
            this.labelFullName1.AccessibleName = "";
            this.labelFullName1.AutoSize = true;
            this.labelFullName1.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelFullName1.Location = new System.Drawing.Point(21, 640);
            this.labelFullName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullName1.Name = "labelFullName1";
            this.labelFullName1.Size = new System.Drawing.Size(126, 24);
            this.labelFullName1.TabIndex = 73;
            this.labelFullName1.Text = "FULL NAME :";
            this.labelFullName1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerQR
            // 
            this.timerQR.Interval = 1000;
            this.timerQR.Tick += new System.EventHandler(this.timerQRTick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arcega_contact_tracing.Properties.Resources.appbackground_65_nature_outdoors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 738);
            this.Controls.Add(this.labelFullName1);
            this.Controls.Add(this.lblFullName1);
            this.Controls.Add(this.lblDate1);
            this.Controls.Add(this.txtbxDateOfVisit1);
            this.Controls.Add(this.lblDateOfVisit1);
            this.Controls.Add(this.txtbxFullName1);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.picbxCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCamera);
            this.Controls.Add(this.lblScanQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formScannerClosing);
            this.Load += new System.EventHandler(this.form7Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScanQR;
        private System.Windows.Forms.ComboBox cboxCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblFullName1;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.TextBox txtbxDateOfVisit1;
        private System.Windows.Forms.Label lblDateOfVisit1;
        private System.Windows.Forms.TextBox txtbxFullName1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelFullName1;
        private System.Windows.Forms.Timer timerQR;
        private System.Windows.Forms.PictureBox picbxCam;
    }
}